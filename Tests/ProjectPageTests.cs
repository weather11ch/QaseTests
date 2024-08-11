using QaseTests.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QaseTests.Tests
{
    internal class ProjectPageTests : BasePageTests
    {        
        [Test]
        public void OpenProjectPageTest() 
        {
            ProjectPage.OpenProjectPage();
        }
        [Test]
        public void CreateNewProjectTest()
        {
            ProjectPage.OpenProjectPage();
        }
        [Test]
        public void OpenDemoProjectTest()
        {
            ProjectPage.OpenDemoProject();
            Thread.Sleep(5000);
        }
    }
}
