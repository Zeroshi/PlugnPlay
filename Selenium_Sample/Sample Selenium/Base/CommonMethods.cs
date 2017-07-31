using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Sample_Selenium.Base
{
    public static class CommonMethods
    {
        public static Boolean isElementPresent(IWebDriver driver, By locator)
        {

            return driver.FindElements(locator).Count > 0;
        }
    }
}
