using OpenQA.Selenium;

namespace DIPLOM.Diplom.Core.Elements
{
    internal class Button : BaseElement
    {
        public Button(By locator) : base(locator)
        {
        }
        
        public Button(string locator) : base($"[id='{locator}']")
        {
        }       
    }
}
