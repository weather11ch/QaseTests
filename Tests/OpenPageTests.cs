using QaseTests.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QaseTests.Tests
{
    internal class OpenPageTests : BasePageTests
    {
        [Test]
        public void OpenPageTest()
        {

        }
        [Test]
        public void AuthorizationTest() 
        {
            BasePage.Authorization();
        }
        [Test]
        public void OpenProjectTest() 
        {
            ProjectPage.OpenProjectPage();
        }

    }
}
