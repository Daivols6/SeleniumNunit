using Diplom.Diplom.Core;
using Diplom.Diplom.PageObject;
using DIPLOM.Diplom.Core;
using Faker;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPLOM.Diplom.PageObject
{
    internal class ChosePayment : BasePage
    {
        private By AlertWarning = By.CssSelector(".alert-warning");


        public ChosePayment() : base()
        {
        }

        public override BasePage OpenPage()
        {
            driver.Navigate().GoToUrl(LoginPage.url);
            return this;
        }
        public void CheckWarning()
        {
            try
            {
                // Поиск элемента на старнице.
                var element = driver.FindElement(AlertWarning);
                var displayed = element.Displayed;
                Assert.IsNotNull(displayed);
            }
            catch (NoSuchElementException)
            {
                // Если элемент не найден, то вызываем AssertionException
                Assert.Fail("Элемент не найден на странице");
            }
        }
    }
}
