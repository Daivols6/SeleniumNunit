using Bogus;
using Diplom.Diplom.Core;
using Faker;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPLOM.Diplom.Core.Elements
{
    public class BaseElement
    {
        public IWebDriver WebDriver => Browser.Instatce.Driver;
        public IWebElement GetElement() => WebDriver.FindElement(locator);
        protected By locator;


        public BaseElement(By locator)
        {
            this.locator = locator;
        }
        public BaseElement(string xpath)
        {
            this.locator = locator;
        }

        public BaseElement()
        {
        }



    }
}
