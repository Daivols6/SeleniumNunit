using Diplom.Diplom.PageObject;
using DIPLOM.Diplom.Core.Configuration;
using DIPLOM.Diplom.Core.Elements;
using NUnit.Allure.Attributes;
using OpenQA.Selenium;

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
        //Отметить чек-бокс согласие с условиями на вкладке Shipping
        public void AgreeAndCheckout()
        {
            new Button(Agree).GetElement().Click();
            new Adresses().Checkout();
            logger.Info($"Agree And Checkout");
        }
    }
}

