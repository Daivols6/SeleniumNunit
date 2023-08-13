using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPLOM.Diplom.Core
{
    internal class WaitHelper
    {
        public static void WaitElement(WebDriver driver, By by, int time)
        {
            new WebDriverWait(driver, TimeSpan.FromSeconds(time)).Until(element => element.FindElement(by).Text.ToLower());
        }

    }
}
