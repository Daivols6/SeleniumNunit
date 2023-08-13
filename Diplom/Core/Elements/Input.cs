using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
