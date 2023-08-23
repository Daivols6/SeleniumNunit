using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace DIPLOM.Diplom.Core.Elements
{
    public class DropDown : BaseElement
    {
        public DropDown(By locator) : base(locator)
        {
        }
        public DropDown(string name) : base($"[id='{name}']")
        {
        }

        public DropDown()
        {
        }

        public void SelectDivList(int value)
        {
            var button = WebDriver.FindElement(locator);
            button.Click();
            for (int i = 0; i < value; i++)
            {
                button.SendKeys(Keys.ArrowDown);

            }
            button.Click();
        }
        public void SelectByValue(By locator, string value)
        {
            var webElement = WebDriver.FindElement(locator);
            var select = new SelectElement(webElement); ;
            select.SelectByValue(value);
        }
        public void SelectByIndexNumber(By locator, int value)
        {
            var webElement = WebDriver.FindElement(locator);
            var select = new SelectElement(webElement); ;
            select.SelectByIndex(value);
        }
    }
}
