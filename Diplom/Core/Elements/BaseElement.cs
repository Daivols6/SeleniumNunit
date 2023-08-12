using Diplom.Diplom.Core;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPLOM.Diplom.Core.Elements
{
    public class BaseElement
    {
        protected IWebDriver WebDriver => Browser.Instatce.Driver;
        public IWebDriver GetElement() => (IWebDriver)WebDriver.FindElement(locator);
        protected By locator;


        public BaseElement(By locator)
        {
            this.locator = locator;
        }
        public BaseElement(string xpath)
        {
            this.locator = locator;
        }

        public void Select(string option) 
        {
/*            Browser.Instatce.Driver.FindElements(Locator).Click();*/
        }
    }
}
