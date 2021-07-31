using HudlUiAcceptanceTests.Helpers;
using HudlUiAcceptanceTests.Pages;
using NUnit.Framework;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace HudlUiAcceptanceTests.Steps
{
    [Binding]
    public class LoginSteps : LoginPage
    {
        public LoginSteps(RemoteWebDriver driver) : base(driver)
        {
        }

        [Given(@"I'm on login page")]
        public void GivenIMOnLoginPage()
        {
            GoToLoginPage();
        }

        [When(@"I login with organization email ""(.*)""")]
        public void GivenILoginWithOrganizationEmail(string email = "")
        {
            LoginWithOrganizationEmail(email);
        }

        [Given(@"I login with username ""(.*)"" & password ""(.*)""")]
        public void WhenILoginWithUsernamePassword(string username = "", string password = "")
        {
            LoginwithUsernameAndPassword(username, password);
        }

        [Given(@"I'm on organization login page")]
        public void GivenIMOnOrganizationLoginPage()
        {
            GoToOrganizationLoginPage();
        }

        [Given(@"message ""(.*)"" is displayed")]
        public void GivenMessageIsDisplayed(string message)
        {
            WaitForElementPresent(HeaderTextElement);
            Assert.AreEqual(HeaderTextElement.Text, message,
                $"{HeaderTextElement.Text}" + " is not same as " + $"{message}");
        }


        [Then(@"I'm able to see my dashboard")]
        public void ThenIMAbleToSeeMyDashboard()
        {
            WaitForElementPresent(LoggedInUsermenu);
            Assert.IsTrue(LoggedInUsermenu.Displayed, "logged in user menu is not displayed");
            Assert.IsTrue(MainUserProfileElement.Displayed, "User profile element is not displayed");
        }

        [Then(@"a message ""(.*)"" is displayed")]
        public void ThenAMessageIsDisplayed(string message)
        {
            WaitForElementPresent(ErrorMessageElement);
            Assert.IsTrue(ErrorMessageElement.Text.Contains(message), $"{message}" + " is not displayed");
            Assert.IsTrue(!LoginElement.Enabled, "login element is not disabled");

            var loginElementColor = LoginElement.GetCssValue("background-Color");
            Assert.AreNotEqual(ColorObject.LightBlue, loginElementColor,
                $"{loginElementColor}" + " should be not same as " + $"{ColorObject.LightBlue}");
        }

        [Then(@"error message ""(.*)"" is displayed")]
        public void ThenErrorMessageIsDisplayed(string message)
        {
            WaitForElementPresent(OrganizationErrorMessageElement);
            Assert.IsTrue(OrganizationErrorMessageElement.Text.Equals(message),
                $"{message}" + " is not displayed");

            var loginElementColor = LoginElement.GetCssValue("background-Color");
            Assert.AreEqual(ColorObject.LightBlue, loginElementColor,
                $"{loginElementColor}" + " should be same as " + $"{ColorObject.LightBlue}");
        }
    }
}
