using HudlUiAcceptanceTests.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace HudlUiAcceptanceTests.Pages
{
    public class HomePage : BasePage
    {
        public IWebElement LoginButton => Driver.FindElementByClassName("login");

        public HomePage(RemoteWebDriver driver) : base(driver)
        {
        }

        public void GoToHomePage()
        {
            NavigateToUrl(ConfigReader.BaseUrl);
            WaitForElementPresent(LoginButton);
        }
    }
}
