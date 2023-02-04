using Microsoft.Graph;
using Azure.Identity;

namespace CommanderEngine
{
    public class GraphHelper
    {

        private static ISettings? _settings;
        private static GraphServiceClient? _userClient;

        private static ClientSecretCredential? _clientSecretCredential;
        private static GraphServiceClient? _appClient; 

        public static void InitializeGraphForUserAuth(ISettings settings,
            Func<DeviceCodeInfo, CancellationToken, Task> deviceCodePrompt)
        {

            _settings = settings;

            var options = new InteractiveBrowserCredentialOptions
            {
                TenantId = _settings.TenantId,
                ClientId = settings.ClientId,
                AuthorityHost = AzureAuthorityHosts.AzurePublicCloud,
                RedirectUri = new Uri("http://localhost"),

            };

            var interactiveCredential = new InteractiveBrowserCredential(options);

            _userClient = new GraphServiceClient(interactiveCredential, _settings.GraphUserScopes);
        }

        public static bool InitializeGraphWithUsername(ISettings settings, string username, string password)
        {

            _settings = settings;

            var credential = new UsernamePasswordCredential(username, password, _settings.TenantId, _settings.ClientId);

            _userClient = new GraphServiceClient(credential, _settings.GraphUserScopes);

            try
            {
                var req = _userClient.Me.Request().GetAsync();
                req.Wait();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public static void InitializeGraphForAppOnlyAuth()
        {

            if (_clientSecretCredential == null)
            {
                _clientSecretCredential = new ClientSecretCredential(
                    Settings.Singleton.TenantId, Settings.Singleton.ClientId, Settings.Singleton.ClientSecret);
            }

            if (_appClient == null)
            {
                _appClient = new GraphServiceClient(_clientSecretCredential,
                    // Use the default scope, which will request the scopes
                    // configured on the app registration
                    new[] { "https://graph.microsoft.com/.default" });
            }
        }

        //Vrati spisak team-ova
        public static Task<IUserJoinedTeamsCollectionPage> GetTeams()
        {
            _ = _userClient ??
               throw new System.NullReferenceException("Graph has not been initialized for user auth");
            return _userClient.Me.JoinedTeams.Request().GetAsync();
        }

        //Vrati podatke o team-u
        public static Task<Team> GetTeam(string id)
        {
            _ = _userClient ?? throw new System.NullReferenceException("Graph has not been initialized for user auth !");
            return _userClient.Teams[id].Request().GetAsync();
        }

        public static Task AddTeam(Team team)
        {
            _ = _userClient ?? throw new System.NullReferenceException("Graph has not been initialized for user auth !");
            return _userClient.Teams.Request().AddAsync(team);
        }

        public static Task RemoveTeam(Team team)
        {
            _ = _userClient ?? throw new System.NullReferenceException("Graph has not been initialized for user auth !");
            return _userClient.Groups[team.Id].Request().DeleteAsync();
        }

        //Tagovi
        public static Task<ITeamTagsCollectionPage> GetTeamTags(string id)
        {
            _ = _appClient ?? throw new System.NullReferenceException("Graph has not been initialized for user auth !");
            return _appClient.Teams[id].Tags.Request().GetAsync();
        }

        public static Task AddTag(string teamID,TeamworkTag tag)
        {
            _ = _appClient ?? throw new System.NullReferenceException("Graph has not been initialized for user auth !");
            return _appClient.Teams[teamID].Tags.Request().AddAsync(tag);
        }

        public static Task RemoveTag(string teamID,string tagID)
        {
            _ = _appClient ?? throw new System.NullReferenceException("Graph has not been initialized for user auth !");
            return _appClient.Teams[teamID].Tags[tagID].Request().DeleteAsync();
        }

        //Dodaj kanal u team
        public static Task AddChannel(string id,Channel channel)
        {
            _ = _userClient ?? throw new System.NullReferenceException("Graph has not been initialized for user auth !");
            return _userClient.Teams[id].Channels.Request().AddAsync(channel);
        }

        //Vrati sve kanale jednog Team-a
        public static Task<ITeamChannelsCollectionPage> GetTeamChannels(string id)
        {
            _ = _userClient ?? throw new System.NullReferenceException("Graph has not been initialized for user auth !");
            return _userClient.Teams[id].Channels.Request().GetAsync();
        }

        //Ukloni kanal iz Team-a
        public static Task RemoveChannel(string teamId,string channelId)
        {
            _ = _userClient ?? throw new System.NullReferenceException("Graph has not been initialized for user auth !");
            return _userClient.Teams[teamId].Channels[channelId].Request().DeleteAsync();
        }

        //Vrati sve clanove jednog Team-a
        public static Task<ITeamMembersCollectionPage> GetTeamMembers(string id)
        {
            _ = _userClient ?? throw new System.NullReferenceException("Graph has not been initialized for user auth !");
            return _userClient.Teams[id].Members.Request().GetAsync();
        }

        //Ukloni clana jednog Team-a
        public static async Task RemoveMember(string teamId,string memberId)
        {
            _ = _userClient ?? throw new System.NullReferenceException("Graph has not been initialized for user auth !");
            await _userClient.Teams[teamId].Members[memberId].Request().DeleteAsync();
        }

        public static async Task AddMember(string teamId,AadUserConversationMember member)
        {
            _ = _userClient ?? throw new System.NullReferenceException("Graph has not been initialized for user auth !");
            await _userClient.Teams[teamId].Members.Request().AddAsync(member);
        }

        public static Task<User> GetMeAsync()
        {
            _ = _userClient ??
                throw new System.NullReferenceException("Graph has not been initialized for user auth");

            return _userClient.Me
                .Request()
                .Select(u => new
                {
                    u.DisplayName,
                    u.Mail,
                    u.UserPrincipalName,
                    u.Id
                })
                .GetAsync();
        }

        public static Task<IGraphServiceUsersCollectionPage> GetUsersAsync()
        {
            _ = _userClient ??
                throw new System.NullReferenceException("Graph has not been initialized for user auth !");

            return _userClient.Users
                .Request()
                .Select(u => new
                {
                    u.DisplayName,
                    u.Id,
                    u.Mail
                })
                .OrderBy("DisplayName")
                .GetAsync();
        }

    }
}
