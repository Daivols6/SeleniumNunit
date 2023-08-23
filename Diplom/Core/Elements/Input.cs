using OpenQA.Selenium;

namespace DIPLOM.Diplom.Core.Elements
{
    internal class Input:BaseElement
    {
        public Input(By locator): base(locator)
        {
        }
        public Input(string locator): base($"//input[@name='{locator}']")
        {
        }

    }
}
