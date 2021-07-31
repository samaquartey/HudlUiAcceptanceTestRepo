using BoDi;
using System.Configuration;
using TechTalk.SpecFlow;

namespace HudlUiAcceptanceTests.TestHooks
{
    [Binding]
    public class Hooks : DriverManager
    {
        //** Browser Type reading from app.config **//
        internal static string Browser = ConfigurationManager.AppSettings["Browser"];
        public IObjectContainer Container { get; set; }

        public Hooks(IObjectContainer container)
        {
            Container = container;
        }

        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            CleanScreenShotFolder();
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
            if (Browser == "chrome")
                KillChromeDriver();
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            Driver = LaunchBrowser(Browser);
            Container.RegisterInstanceAs(Driver);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            TakeScreenShot();
            CloseBrowser();
        }
    }
}
