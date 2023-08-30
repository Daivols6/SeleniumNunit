using Diplom.Diplom.PageObject;
using DIPLOM.Diplom.Core;
using DIPLOM.Diplom.Core.Configuration;
using DIPLOM.Diplom.Core.Elements;
using NUnit.Allure.Attributes;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace DIPLOM.Diplom.PageObject
{
    internal class RegistrationPage : BasePage
    {
        private By Mobilephone = By.Id("phone_mobile");
        private By Homephone = By.Id("phone");
        private By City = By.Id("city");
        private By Zip = By.Id("postcode");
        private By Address = By.Id("address1");
        private By LastName = By.Id("lastname");
        private By FirstName = By.Id("firstname");
        private By State = By.XPath("//*[@id='id_state']");
        private By Country = By.XPath("//*[@id='id_country']");
        private By SaveAndContinue = By.Id("submitAddress");
        private By addressTitle = By.CssSelector("#alias");
        private readonly int Digit = new Random().Next(1, 7);
        public string URL = "http://prestashop.qatestlab.com.ua/ru/";
       
        public RegistrationPage() : base()
        {
        }

        ///<summary>
        ///Заполнение данных пользователя на вкладке YOUR ADDRESSES с указанием случайного Штата и страны под индексом 1
        ///</summary>
        /// <returns></returns>
        [AllureStep("Input Address for User")]
        public RegistrationPage EnterAddressforUser()
        {
            new DropDown().SelectByIndexNumber(Country, 1);
            logger.Info($"Choosing a country");
            new DropDown().SelectByIndexNumber(State, Digit);
            logger.Info($"Choosing a state");
            var user = UserBuilder.GetDataUserForRegistration();
            logger.Info($"Getting a new user");
            driver.FindElement(FirstName).SendKeys(user.FirstName);
            logger.Info($"Input FirstName");
            driver.FindElement(LastName).SendKeys(user.LastName);
            logger.Info($"Input LastName");
            driver.FindElement(Address).SendKeys(user.Address);
            logger.Info($"Input Address");
            driver.FindElement(Zip).SendKeys(user.Zip);
            logger.Info($"Input Zip");
            driver.FindElement(City).SendKeys(user.City);
            logger.Info($"Input City");
            driver.FindElement(Homephone).SendKeys(user.Homephone);
            logger.Info($"Input Homephone");
            driver.FindElement(Mobilephone).SendKeys(user.Mobilephone);
            logger.Info($"Input Mobilephone");
            driver.FindElement(addressTitle).SendKeys(user.AddressTitle);
            logger.Info($"Input AddressTitle");
            driver.FindElement(SaveAndContinue).Click();
            logger.Info($"Click on button SaveAndContinue");
            return new RegistrationPage();
        }

        ///<summary>
        ///Заполнение данных пользователя на вкладке YOUR ADDRESSES с указанием случайного Штата, страна остается выбранная по умолчанию(Index(0))
        ///</summary>
        /// <returns></returns>
        [AllureStep]
        public RegistrationPage EnterAddressUSAforUser()
        {
            new DropDown().SelectByIndexNumber(State, Digit);
            logger.Info($"Choosing a state");
            var user = UserBuilder.GetDataUserForRegistration();
            logger.Info($"Getting a new user");
            driver.FindElement(FirstName).SendKeys(user.FirstName);
            logger.Info($"Input FirstName");
            driver.FindElement(LastName).SendKeys(user.LastName);
            logger.Info($"Input LastName");
            driver.FindElement(Address).SendKeys(user.Address);
            logger.Info($"Input Address");
            driver.FindElement(Zip).SendKeys(user.Zip);
            logger.Info($"Input Zip");
            driver.FindElement(City).SendKeys(user.City);
            logger.Info($"Input City");
            driver.FindElement(Homephone).SendKeys(user.Homephone);
            logger.Info($"Input Homephone");
            driver.FindElement(Mobilephone).SendKeys(user.Mobilephone);
            logger.Info($"Input Mobilephone");
            driver.FindElement(addressTitle).SendKeys(user.AddressTitle);
            logger.Info($"Input AddressTitle");
            driver.FindElement(SaveAndContinue).Click();
            logger.Info($"Click on button SaveAndContinue");
            return new RegistrationPage();
        }
        
        public override BasePage OpenPage()
        {
            driver.Navigate().GoToUrl(URL);
            logger.Info($"Open page{URL}");
            return this;
        }
    }
}

