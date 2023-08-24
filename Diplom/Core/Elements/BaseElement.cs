using Diplom.Diplom.Core;
using OpenQA.Selenium;

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
