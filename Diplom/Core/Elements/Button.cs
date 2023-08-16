using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
