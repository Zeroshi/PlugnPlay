using System;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using Sample_Selenium.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sample_Selenium.Base;

namespace Sample_Selenium
{
    [TestClass]
    public class UnitTest1
    {
        private static IWebDriver driver;
        private HomePage homepage = new HomePage();

        [ClassInitialize]
        public static void initializeBrowser(TestContext e)
        {
            driver = DriverProvider.getDriver();
        }

        [TestMethod,TestCategory("BVT"),WorkItem(6)]
        public void Search()
        {
            driver.Navigate().GoToUrl("https://weather.com/");
            homepage.SearchText();
        }

        [ClassCleanup]
        public static void Destroy()
        {
            driver.Dispose();
        }
     
    }
}
