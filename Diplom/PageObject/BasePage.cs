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


        ///<summary>
        /// Проверка что элемент есть на странице
        ///</summary>
        public bool CheckElementOnPage(By locator)
        {
            try
            {
                var element = driver.FindElement(locator);
                return element.Displayed;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка при поиске элемента: " + ex.Message);
                return false;
            }
        }
    }
}
