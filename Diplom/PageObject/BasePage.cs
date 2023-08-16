using Diplom.Diplom.Core;
using NLog;
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
        protected static Logger logger = LogManager.GetCurrentClassLogger();
        public BasePage()
        {
            driver = Browser.Instatce.Driver;
        }
        public abstract BasePage OpenPage();
    }
}
