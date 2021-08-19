using HudlUiAcceptanceTests.TestHooks;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System;
using System.Net;
using System.Threading;

namespace HudlUiAcceptanceTests.Pages
{
    public class BasePage : DriverManager
    {
        public IWebElement Element { get; set; }
        public Actions Actions => new Actions(Driver);
        public WebDriverWait Wait => new WebDriverWait(Driver, TimeSpan.FromSeconds(10));

        public BasePage(RemoteWebDriver driver)
        {
            Driver = driver;
        }

        //navigate to url
        public void NavigateToUrl(string baseUrl)
        {
            Driver.Navigate().GoToUrl(baseUrl);
            WaitForPageLoad();
        }

        //Wait for page load
        public void WaitForPageLoad()
        {
            Wait.Until(e => ((IJavaScriptExecutor)Driver)
                .ExecuteScript("return document.readyState").Equals("complete"));
            for (var i = 0; i < 30; i++)
            {
                Wait.Until(e => ((IJavaScriptExecutor)Driver)
                    .ExecuteScript("return document.readyState").Equals("complete"));
            }
        }

        //Mouse hover
        public void HoverOverElement(IWebElement element)
        {
            WaitForElementPresent(element);
            Actions.MoveToElement(element).Build().Perform();
        }

        //Click on element
        public void ClickOnElement(IWebElement element)
        {
            HoverOverElement(element);
            element.Click();
        }

        //Submit element
        public void SubmitElement(IWebElement element)
        {
            HoverOverElement(element);
            element.Submit();
        }

        //Send keys to element
        public void SendKeysToElement(IWebElement element, string keys)
        {
            HoverOverElement(element);
            element.Clear();
            element.SendKeys(Keys.Clear);
            element.SendKeys(keys);
        }

        //Wait for element present
        public void WaitForElementPresent(IWebElement element)
        {
            var isDisplayed = true;
            do
            {
                try
                {
                    Wait.Until(e => element.Displayed);
                    isDisplayed = element.Displayed;
                }
                catch (NullReferenceException)
                {
                    Console.WriteLine(element + " was not found in current context page.");
                }
                catch (WebDriverTimeoutException)
                {
                    Console.WriteLine(element + " was not found in current context page.");
                }
                catch (NoSuchElementException)
                {
                    Console.WriteLine(element + " was not found in current context page.");
                }
                catch (StaleElementReferenceException)
                {
                    Console.WriteLine(element + " was not found in current context page.");
                }
                catch (WebDriverException)
                {
                    Console.WriteLine(element + " was not found in current context page.");
                }
                catch (WebException)
                {
                    Console.WriteLine(element + " was not found in current context page.");
                }
            } while (!isDisplayed);
        }
    }
}
