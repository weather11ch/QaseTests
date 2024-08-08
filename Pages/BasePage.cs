using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using QaseTests.Factories;
using SeleniumExtras.WaitHelpers;


namespace QaseTests.Pages
{
    internal class BasePage
    {
        protected static IWebDriver driver = Driver.GetDriver();
        protected static WebDriverWait wait = Driver.WaitDriver(driver, 30);
        public static IWebElement emailField;
        public static IWebElement passwordField;
        public static IWebElement signIn;
        public static void OpenMainPage()
        {
            Driver.GetDriver().Navigate().GoToUrl("https://app.qase.io/");

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
            passwordField.Click();
            Thread.Sleep(1000);
            //*[@id="app"]/div/div[1]/section[2]/form/div[2]/div/input   //*[@id="app"]/div/div[1]/section[2]/form/button
        }
    }
}
