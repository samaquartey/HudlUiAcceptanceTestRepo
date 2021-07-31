using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Remote;
using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace HudlUiAcceptanceTests.TestHooks
{
    public class DriverManager
    {
        protected RemoteWebDriver Driver { get; set; }

        #region Select Browser Type
        public RemoteWebDriver LaunchBrowser(string browser)
        {
            var options = new ChromeOptions();
            switch (browser)
            {
                case "chrome":

                    options.AddArguments("--disable-infobars");
                    options.AddArguments("--no-sandbox");
                    options.AddArguments("--disable-gpu");
                    options.AddArguments("--disable-setuid-sandbox");
                    Driver = new ChromeDriver(options);
                    Driver.Manage().Window.Maximize();
                    break;

                case "edge":
                    Driver = new EdgeDriver();
                    Driver.Manage().Window.Maximize();
                    break;
            }
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            return Driver;
        }
        #endregion


        #region Close Browser
        public void CloseBrowser()
        {
            try
            {
                Driver?.Quit();
                Driver = null;
            }
            catch (Exception e)
            {
                Console.WriteLine(e + " Browser did not close");
            }
        }
        #endregion

        //Clean screenshots folder before test run
        public static void CleanScreenShotFolder()
        {
            var screenShotFolder = GetScreenShotFolderName();
            if (!Directory.Exists(screenShotFolder))
            {
                Directory.CreateDirectory(screenShotFolder);
            }
            var filePaths = Directory.GetFiles(screenShotFolder);
            foreach (var filePath in filePaths)
                File.Delete(filePath);
        }


        //ScreenShot Folder Path
        public static string GetScreenShotFolderName()
        {
            var path = Assembly.GetCallingAssembly().CodeBase;
            var actualPath = path.Substring(0, path.LastIndexOf("bin", StringComparison.Ordinal));
            var projectPath = new Uri(actualPath).LocalPath;
            var screenShotFolder = projectPath + "ScreenShot\\";
            return screenShotFolder;
        }


        //Screenshots Method
        public void TakeScreenShot()
        {
            var screenShotFolder = GetScreenShotFolderName();
            var time = DateTime.Now;
            var dateTimeNow = "_" + time.ToString("dd-MM-yyyy") + "_" + time.ToString("HH-mm-ss") + "_";
            var nameOfFailedTest = TestContext.CurrentContext.Test.MethodName;

            try
            {
                if (TestContext.CurrentContext.Result.Outcome == ResultState.Success) return;
                {
                    var screenshot = ((ITakesScreenshot)Driver).GetScreenshot();
                    screenshot.SaveAsFile(screenShotFolder + nameOfFailedTest + dateTimeNow + "screenshot.jpeg",
                        ScreenshotImageFormat.Jpeg);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e + "screenshot was not taken");
                throw;
            }
        }

        public static void KillChromeDriver()
        {
            try
            {
                foreach (var proc in Process.GetProcessesByName("chromedriver"))
                {
                    proc.Kill();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
