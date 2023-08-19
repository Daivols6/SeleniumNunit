using Diplom.Diplom.PageObject;
using DIPLOM.Diplom.Core.Configuration;
using NUnit.Framework;
using OpenQA.Selenium;

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
            logger.Info($"Open page{LoginPage.url}");
            AllureHelper.ScreenShot();
            return this;
        }
        public void CheckWarning()
        {

            // Поиск элемента на старнице.
            var element = driver.FindElement(AlertWarning);

            Assert.IsTrue(element.Displayed, "Элемент не найден на странице");

        }
    }
}
