using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace HudlUiTest.Pages
{
    public class LoginPage : HomePage
    {
        public IWebElement EmailTextInputElement => Driver.FindElementById("email");
        public IWebElement PasswordTextInputElement => Driver.FindElementById("password");
        public IWebElement LoginElement => Driver.FindElementById("logIn");
        public IWebElement RememberMeCheckBoxElement => Driver.FindElementById("remember-me");
        public IWebElement LoggedInUsermenu => Driver.FindElementByClassName("hui-globalusermenu");
        public IWebElement MainUserProfileElement => Driver.FindElementById("koMain");
        public IWebElement ErrorMessageElement => Driver.FindElementByClassName("login-error-container");
        public IWebElement LoginOrganizationButton => Driver.FindElementById("logInWithOrganization");
        public IWebElement OrganizationEmailInputField => Driver.FindElementById("uniId_1");
        public IWebElement OrganizationLoginButton => Driver.FindElementByClassName("uni-button--primary");
        public IWebElement OrganizationErrorMessageElement => Driver.FindElementByClassName("login-error-container-code");
        public IWebElement HeaderTextElement => Driver.FindElementByClassName("_3ZchjyyL4lRtJSkmDHSLIy");


        public LoginPage(RemoteWebDriver driver) : base(driver)
        {
        }

        public void GoToLoginPage()
        {
            GoToHomePage();
            ClickOnElement(LoginButton);
            WaitForElementPresent(RememberMeCheckBoxElement);
        }

        public void LoginwithUsernameAndPassword(string username, string password)
        {
            SendKeysToElement(EmailTextInputElement, username);
            SendKeysToElement(PasswordTextInputElement, password);
            ClickOnElement(LoginElement);
        }

        public void GoToOrganizationLoginPage()
        {
            ClickOnElement(LoginOrganizationButton);
        }

        public void LoginWithOrganizationEmail(string email)
        {
            SendKeysToElement(OrganizationEmailInputField, email);
            SubmitElement(OrganizationLoginButton);
        }
    }
}
