using Diplom.Diplom.Core;
using Diplom.Diplom.PageObject;
using DIPLOM.Diplom.Core;
using DIPLOM.Diplom.Core.Configuration;
using DIPLOM.Diplom.Core.Elements;
using Faker;
using NUnit.Allure.Attributes;
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
    internal class ShippingPage : BasePage
    {
        private By Agree = By.CssSelector("#cgv");

        public ShippingPage() : base()
        {
        }


        public override BasePage OpenPage()
        {
            driver.Navigate().GoToUrl(LoginPage.url);
            logger.Info($"Open page{LoginPage.url}");
            AllureHelper.ScreenShot();
            return this;
        }
        public void SetCheckBoxState(IWebElement element, bool flag = false)
        {
            var selected = element.Selected;

            if (selected == flag)
            {
                element.Click();
            }
        }
        [AllureStep]
        public void AgreeAndCheckout()
        {
            new Button(Agree).GetElement().Click();
            AllureHelper.ScreenShot();
            new Adresses().Checkout();
            AllureHelper.ScreenShot();
            logger.Info($"Agree And Checkout");
        }
    }
}

