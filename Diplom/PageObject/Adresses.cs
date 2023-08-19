using Diplom.Diplom.PageObject;
using DIPLOM.Diplom.Core.Configuration;
using DIPLOM.Diplom.Core.Elements;
using NUnit.Allure.Attributes;
using OpenQA.Selenium;

namespace DIPLOM.Diplom.PageObject
{
    internal class Adresses : BasePage
    {

        private By ProceedToCheckout = By.CssSelector("button.button-medium");

        public Adresses() : base()
        {
        }

        [AllureStep]
        public override BasePage OpenPage()
        {
            driver.Navigate().GoToUrl(LoginPage.url);
            logger.Info($"Open page{LoginPage.url}");
            AllureHelper.ScreenShot();
            return this;
        }
        public void Checkout()
        {
            new Button(ProceedToCheckout).GetElement().Click();
            logger.Info($"Click on button ProceedToCheckout");
            AllureHelper.ScreenShot();
        }
    }
}
