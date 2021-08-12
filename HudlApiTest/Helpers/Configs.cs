using System.Configuration;

namespace HudlApiTest.Helpers
{
    public class Configs
    {
        static Configs()
        {
            GetOpponentInfomationApi = ConfigurationManager.AppSettings["GetOpponentInfomationApi"];
            PostOpponentInfomationApi = ConfigurationManager.AppSettings["PostOpponentInfomationApi"];
            PutOpponentInfomationApi = ConfigurationManager.AppSettings["PutOpponentInfomationApi"];
            DeleteOpponentInfomationApi = ConfigurationManager.AppSettings["DeleteOpponentInfomationApi"];
        }

        public static string GetOpponentInfomationApi { get; set; }
        public static string PostOpponentInfomationApi { get; set; }
        public static string PutOpponentInfomationApi { get; set; }
        public static string DeleteOpponentInfomationApi { get; set; }
    }
}
