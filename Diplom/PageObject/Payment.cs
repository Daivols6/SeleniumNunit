using DIPLOM.Diplom.Core.Configuration;
using Diplom.Diplom.PageObject;
using NUnit.Allure.Attributes;
using OpenQA.Selenium;
using NUnit.Framework;

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
        //Выбор оплаты банковским платежем
        public Payment ChoisePaymentByBankTransfer()
        {
            driver.FindElement(PaymentByBankTransfer).Click();
            logger.Info($"Payment By Bank Transfer");
            return new Payment();
        }
        //Выбор способа оплаты на вкладке Payment
        public Payment ChoisePaymentByCheck()
        {
            driver.FindElement(PaymentByCheck).Click();
            logger.Info($"Payment By Check");
            return new Payment();
        }
        //Подтверждение оплаты
        public Payment AgreePayment()
        {
            driver.FindElement(AgreePay).Click();
            logger.Info($"Agree And Checkout");
            return new Payment();
        }
        [AllureStep]
        //Проверка что заказ оформлен, поиск сообщения об успешно оформленном заказе.
        public Payment CheckSuccessMessage()
        {
            // Поиск элемента на старнице.
            var element = driver.FindElement(successMessage);
            Assert.IsTrue(element.Displayed, "Элемент не найден на странице");
            logger.Info($"Element found on page");
            return new Payment();
        }
        [AllureStep]
        //Поиск сообщения об ошибке
        public Payment CheckErrorMessage()
        {
            // Поиск элемента на старнице.
            var element = driver.FindElement(erorrMessage);
            Assert.IsTrue(element.Displayed, "Элемент не найден на странице");
            logger.Info($"Element found on page");
            return new Payment();
        }
    }
}
