using QaseTests.Factories;
using QaseTests.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QaseTests.Tests
{
    public class BasePageTests
    {
        [SetUp]
        public void Setup()
        {
            Driver.GetDriver();
            Driver.WaitDriver(Driver.GetDriver(), 30);
            BasePage.OpenMainPage();
            BasePage.Authorization();
            Thread.Sleep(10000);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.QuitDriver();
        }
    }
}
