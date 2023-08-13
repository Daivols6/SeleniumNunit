using Diplom.Diplom.Core;
using Diplom.Diplom.PageObject;
using DIPLOM.Diplom.Core;
using DIPLOM.Diplom.Core.Elements;
using Faker;
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
    internal class Adresses : BasePage
    {

        private By ProceedToCheckout = By.CssSelector("button.button-medium");

        public Adresses() : base()
        {
        }


        public override BasePage OpenPage()
        {
            driver.Navigate().GoToUrl(LoginPage.url);
            return this;
        }
        public void Checkout()
        {
            new Button(ProceedToCheckout).GetElement().Click();
        }
    }
}
