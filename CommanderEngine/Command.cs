using Microsoft.Graph;

namespace CommanderEngine
{
    public class CommandResponse
    {   
        public bool isSuccessful { get; set; }
        public string Message{ get; set; }

        public CommandResponse(bool isSuccessful,string Message) { this.isSuccessful = isSuccessful;this.Message = Message; }
    }

    public interface Command
    {
        public string Description { get; set; }
        public abstract CommandResponse Execute();
    }


    #region TeamCommands
    public class AddTeam : Command
    {
        private Team team;
        private string desc;
        public AddTeam(Team body) { this.team = body; desc = "Creating team '" + team.DisplayName + "' !"; }

        public string Description { get { return desc; } set { desc = value; } }

        public CommandResponse Execute()
        {
            try
            {
                var request = GraphHelper.AddTeam(team);
                request.Wait();
                
                return new CommandResponse(true, "Successfully created a team !");
            }
            catch(Exception e)
            {
                return new CommandResponse(false,e.Message);
            }
        }

    }

    public class DeleteTeam : Command
    {
        private Team team;
        private string desc;
        public string Description { get { return desc; } set { desc = value; } }

        public DeleteTeam(Team body) { this.team = body; desc = "Deleting team '" + team.DisplayName + "' !"; }
        public CommandResponse Execute()
        {
            try
            {
                var request = GraphHelper.RemoveTeam(team);
                request.Wait();
                return new CommandResponse(true, "Successfully deleted a team !");
            }
            catch (Exception e)
            {
                return new CommandResponse(false, e.Message);
            }
        }

    }

    #endregion
}
