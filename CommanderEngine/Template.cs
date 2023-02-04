using Microsoft.Graph;
using Microsoft.Graph.TermStore;
using System.IO;

namespace CommanderEngine
{
    public class Template
    {
        public string TemplateName { get; set; }

        public string TemplateDescription { get; set; }
        public TeamChannelsCollectionPage Channels { get; set; }
        public TeamMemberSettings MemberSettings { get; set; }
        public TeamMessagingSettings MessagingSettings { get; set; }

        public Template()
        {
            TemplateName = "New Template";
            TemplateDescription = "New description";
            Channels = new TeamChannelsCollectionPage();
            MemberSettings = new TeamMemberSettings();
            MessagingSettings= new TeamMessagingSettings();
        }

        public static List<Template> LoadFromFile(string filepath)
        {
            Serializer helper = new Serializer();
            
            FileStream f = new FileStream(filepath, FileMode.OpenOrCreate, FileAccess.Read);
            List<Team> teams = helper.DeserializeObject<List<Team>>(f);
            f.Close();

            List<Template> res = new List<Template>();

            if (teams != null)
            {
                foreach (Team team in teams)
                {
                    Template t = new Template();
                    t.TemplateName = team.DisplayName;
                    t.TemplateDescription = team.Description;
                    t.Channels = (TeamChannelsCollectionPage)team.Channels;
                    t.MemberSettings = (TeamMemberSettings)team.MemberSettings;
                    t.MessagingSettings = (TeamMessagingSettings)team.MessagingSettings;

                    res.Add(t);
                }
                return res;
            }
            else
            {
                return new List<Template>();
            }
        }

        public static void SaveAsList(string filepath,List<Template> templates)
        {
            List<Team> teams = new List<Team>();

            foreach(Template t in templates)
            {
                var team = new Team
                {
                    DisplayName = t.TemplateName,
                    Description = t.TemplateDescription,
                    Channels = t.Channels,
                    MemberSettings = t.MemberSettings,
                    MessagingSettings = t.MessagingSettings
                };
                teams.Add(team);
            }

            Microsoft.Graph.Serializer helper = new Microsoft.Graph.Serializer();
            string content = helper.SerializeObject(teams);

            System.IO.File.WriteAllText(filepath, content);

        }

        public Team CreateFromTemplate(string Name, string Description)
        {
            var req = GraphHelper.GetMeAsync();
            req.Wait();
            string userId = req.Result.Id;

            var team = new Team
            {
                AdditionalData = new Dictionary<string, object>()
                {
                    {"template@odata.bind", "https://graph.microsoft.com/v1.0/teamsTemplates('standard')"}
                },
                DisplayName = Name,
                Description = Description,
                Channels = this.Channels,
                MemberSettings = this.MemberSettings,
                MessagingSettings = this.MessagingSettings
            };

           
            return team;
        }

        public override string ToString() { return this.TemplateName; }

        public static Template Standard {
            get
            {
                var req = GraphHelper.GetMeAsync();
                req.Wait();
                string userId = req.Result.Id;

                Template temp = new Template();
                temp.TemplateName = "Standard";
                temp.TemplateDescription = "This is a standard MSTeams template !";
                temp.Channels = new TeamChannelsCollectionPage
                {
                    new Channel
                    {
                        DisplayName="General",
                        Description="This is a general channel",
                        MembershipType=ChannelMembershipType.Standard
                    }
                };
                temp.MemberSettings = new TeamMemberSettings();
                temp.MessagingSettings = new TeamMessagingSettings();
                return temp;
            }
        }

    }
}
