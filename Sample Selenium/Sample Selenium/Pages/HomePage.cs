using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using OpenQA.Selenium;
using Sample_Selenium.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Sample_Selenium.Pages
{
    class HomePage
    {
        private IWebDriver driver;
        public HomePage()
        {
            driver = DriverProvider.getDriver();
        }

        public void SearchText()
        {
            IWebElement searchbox = driver.FindElement(By.ClassName("input--search"));
            searchbox.Click();
            searchbox.SendKeys("New York, NY");
            Thread.Sleep(5000);
            searchbox.SendKeys(Keys.Tab);
            searchbox.SendKeys(Keys.Enter);
            Thread.Sleep(15000);
            string myTitle = driver.Title;
            Assert.IsTrue(myTitle.Contains("New York, NY Weather Forecast and Conditions - The Weather Channel | Weather.com"), myTitle + " New York, NY Weather Forecast and Conditions - The Weather Channel | Weather.com");
            Thread.Sleep(300);
        }
        }


    }