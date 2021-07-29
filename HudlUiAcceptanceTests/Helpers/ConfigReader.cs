using System.Configuration;

namespace HudlUiTest.Helpers
{
    public class ConfigReader
    {
        static ConfigReader()
        {
            Browser = ConfigurationManager.AppSettings["Browser"];
            BaseUrl = ConfigurationManager.AppSettings["BaseUrl"];
            DefaultTimeout = ConfigurationManager.AppSettings["DefaultTimeout"];
        }

        public static string Browser { get; set; }
        public static string BaseUrl { get; set; }
        public static string DefaultTimeout { get; set; }
    }
}
