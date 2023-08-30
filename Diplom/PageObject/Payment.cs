using DIPLOM.Diplom.Core.Configuration;
using Diplom.Diplom.PageObject;
using NUnit.Allure.Attributes;
using OpenQA.Selenium;
using NUnit.Framework;
using Diplom.Diplom.Core;

namespace DIPLOM.Diplom.PageObject
{
    internal class Payment : BasePage
    {
        private By PaymentByBankTransfer = By.CssSelector(".bankwire");
        private By PaymentByCheck = By.CssSelector(".cheque");
        private By AgreePay = By.CssSelector("#cart_navigation > button");
        private By successMessage = By.CssSelector(".alert-success");
        private By erorrMessage = By.CssSelector(".alert");
        private string url = "http://prestashop.qatestlab.com.ua/ru/order?multi-shipping=";
        public Payment() : base()
        {
        }
        public override BasePage OpenPage()
        {
            driver.Navigate().GoToUrl(url);
            logger.Info($"Open page{url}");
            return this;
        }
        ///<summary>
        /// Выбор оплаты банковским платежем
        ///</summary>
        /// <returns></returns>
        public Payment ChoisePaymentByBankTransfer()
        {
            driver.FindElement(PaymentByBankTransfer).Click();
            logger.Info($"Payment By Bank Transfer");
            return new Payment();
        }
        ///<summary>
        /// Выбор способа оплаты чеком
        ///</summary>
        /// <returns></returns>
        public Payment ChoisePaymentByCheck()
        {
            driver.FindElement(PaymentByCheck).Click();
            logger.Info($"Payment By Check");
            return new Payment();
        }
        ///<summary>
        /// Подтверждение покупки
        ///</summary>
        /// <returns></returns>
        public Payment AgreePayment()
        {
            driver.FindElement(AgreePay).Click();
            logger.Info($"Agree And Checkout");
            return new Payment();
        }

        ///<summary>
        /// Проверка что заказ оформлен, поиск сообщения об успешно оформленном заказе.
        ///</summary>
        /// <returns></returns>
        [AllureStep]
        public Payment CheckSuccessMessage()
        {
            Assert.IsTrue(CheckElementOnPage(successMessage), "Элемент не найден на странице");
            logger.Info($"Element found on page");
            return new Payment();
        }

        ///<summary>
        ///Поиск сообщения об ошибке
        ///</summary>
        /// <returns></returns>
        [AllureStep]
        public Payment CheckErrorMessage()
        {
            Assert.IsTrue(CheckElementOnPage(erorrMessage), "Элемент не найден на странице");
            logger.Info($"Element found on page");
            return new Payment();
        }
    }
}
