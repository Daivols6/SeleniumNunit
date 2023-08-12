using Diplom.Diplom.Core;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom.Diplom.PageObject
{
    internal abstract class BasePage
    {
        protected IWebDriver driver;
        public BasePage()
        {
            driver = Browser.Instatce.Driver;
        }
        public abstract BasePage OpenPage();
    }
}
