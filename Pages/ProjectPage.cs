using OpenQA.Selenium;
using QaseTests.Factories;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QaseTests.Pages
{
    internal class ProjectPage : BasePage
    {
        public static void OpenProjectPage()
        {
            Driver.GetDriver().Navigate().GoToUrl("https://app.qase.io/projects");

            Driver.GetDriver().Manage().Window.Maximize();
            signIn = Driver.WaitDriver(driver, 30).Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"application-content\"]/div/h1")));
            signIn.Click();
        }
        public static void OpenDemoProject() 
        { 
        demoProjectElement = Driver.WaitDriver(driver, 30).Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"application-content\"]/div/table/tbody/tr[1]/td[3]/div/div/a")));
        
        demoProjectElement.Click();

        demoProjectPageElement = Driver.WaitDriver(driver, 30).Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"application-content\"]/div/div[1]/h1")));
        }
    }
}
