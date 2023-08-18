using DIPLOM.Diplom.Core.Configuration;
using DIPLOM.Diplom.Core.Elements;
using Diplom.Diplom.PageObject;
using NUnit.Allure.Attributes;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace DIPLOM.Diplom.PageObject
{
    internal class Payment: BasePage
    {
        private By PaymentByBankTransfer = By.CssSelector(".bankwire");
        private By PaymentByCheck = By.CssSelector(".cheque");
        private By AgreePay = By.CssSelector("#cart_navigation > button");
        private By successMessage = By.CssSelector(".alert-success");

        private string url = "http://prestashop.qatestlab.com.ua/ru/order?multi-shipping=";

        public Payment() : base()
        {
        }


        public override BasePage OpenPage()
        {
            driver.Navigate().GoToUrl(url);
            logger.Info($"Open page{url}");
            AllureHelper.ScreenShot();
            return this;
        }
        public Payment ChoisePaymentByBankTransfer()
        {
            driver.FindElement(PaymentByBankTransfer).Click();
            AllureHelper.ScreenShot();
            logger.Info($"Payment By Bank Transfer");
            return new Payment();
        }
        public Payment ChoisePaymentByCheck()
        {
            driver.FindElement(PaymentByCheck).Click();
            logger.Info($"Payment By Check");
            return new Payment();
        }
        public Payment AgreePayment()
        {
            driver.FindElement(AgreePay).Click();
            AllureHelper.ScreenShot();
            logger.Info($"Agree And Checkout");
            return new Payment();
        }

        [AllureStep]
        public Payment CheckSuccessMessage()
        {
                // Поиск элемента на старнице.
                var element = driver.FindElement(successMessage);
                Assert.IsTrue(element.Displayed, "Элемент не найден на странице");
                logger.Info($"Element found on page");
                AllureHelper.ScreenShot();

            return new Payment();
        }
    }
}
