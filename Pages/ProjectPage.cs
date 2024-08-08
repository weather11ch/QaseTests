using QaseTests.Factories;
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
        }
    }
}
