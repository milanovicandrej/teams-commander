using Config.Net;

namespace CommanderEngine
{
    public class Settings
    {
        public static ISettings? Singleton { get; set; }

        public static void LoadSettings()
        {
            Singleton = new ConfigurationBuilder<ISettings>().UseJsonFile("config.json").Build();
        }

        public static void DefaultSettings()
        {
            Singleton = new ConfigurationBuilder<ISettings>().UseJsonFile("config.json").Build();

            Singleton.ClientId = "31bb72f9-d571-499d-b0f2-65c3ac740ec5";
            Singleton.ClientSecret = "UDp8Q~fAtvpWQ.cvtwzUmfU3XkMVNlBbTOj9XbX-";
            Singleton.TenantId = "fdd7ad60-60b3-47b9-8a20-c12a807bbd33";
            Singleton.AuthTenant = "common";
            Singleton.TemplateFilePath = System.Environment.CurrentDirectory +"\\templates.json";
            Singleton.Version = "1.4.1";
            Singleton.GraphUserScopes = new string[] {
                "user.read", 
                "mail.read", 
                "mail.send",
                "team.readbasic.all", 
                "channel.readbasic.all" ,
                "team.create",
                "user.readwrite.all",
                "teammember.readwrite.all"
            };   
            
            Singleton.DefaultUser = "admin@3pwb6b.onmicrosoft.com";
        }
    }
}
