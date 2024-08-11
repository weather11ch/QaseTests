using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using QaseTests.Factories;
using SeleniumExtras.WaitHelpers;


namespace QaseTests.Pages
{
    internal class BasePage : WebElements
    {
        protected static IWebDriver driver = Driver.GetDriver();
        protected static WebDriverWait wait = Driver.WaitDriver(driver, 30);

        public static void OpenPage(string url)
        {
            Driver.GetDriver().Navigate().GoToUrl($"{url}");
            //Driver.GetDriver().PageSource.

            Driver.GetDriver().Manage().Window.Maximize();
        }
        public static void CloseMainPage()
        {
            driver.Close();
        }

        public static void Authorization()
        {
            emailField = Driver.WaitDriver(driver, 30).Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"app\"]/div/div[1]/section[2]/form/div[1]/div/input")));
            emailField.Click();
            emailField.SendKeys("petijom149@alientex.com");
            passwordField = Driver.WaitDriver(driver, 30).Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"app\"]/div/div[1]/section[2]/form/div[2]/div/input")));
            passwordField.Click();
            passwordField.SendKeys("12345Tt12345!");

            signIn =  Driver.WaitDriver(driver, 30).Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"app\"]/div/div[1]/section[2]/form/button")));
            signIn.Click();                      
            Thread.Sleep(1000);
        }
    }
}
