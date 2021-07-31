using System.Configuration;

namespace HudlUiAcceptanceTests.Helpers
{
    public class ConfigReader
    {
        static ConfigReader()
        {
            Browser = ConfigurationManager.AppSettings["Browser"];
            BaseUrl = ConfigurationManager.AppSettings["BaseUrl"];
        }

        public static string Browser { get; set; }
        public static string BaseUrl { get; set; }
    }
}
