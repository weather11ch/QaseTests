using QaseTests.Factories;
using QaseTests.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QaseTests.Tests
{
    internal class Tests
    {
        [SetUp]
        public void Setup()
        {
            Driver.GetDriver();
            Driver.WaitDriver(Driver.GetDriver(), 30);
            BasePage.OpenMainPage();
            Thread.Sleep(1000);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.QuitDriver();
        }

        [Test]
        public void OpenProjectTest()
        {
            ProjectPage.OpenProjectPage();
        }
    }
}
