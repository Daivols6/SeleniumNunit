using Diplom.Diplom.PageObject;
using DIPLOM.Diplom.Core;
using DIPLOM.Diplom.Core.Configuration;
using DIPLOM.Diplom.Core.Elements;
using NUnit.Allure.Attributes;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace DIPLOM.Diplom.PageObject
{
    internal class RegistrationPage: BasePage
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
        public string URL = "http://prestashop.qatestlab.com.ua/ru/";


        public RegistrationPage() : base()
        {
        }
        [AllureStep("Input Address for User")]
        public RegistrationPage EnterAddressforUser()
        {
            var select = new SelectElement(driver.FindElement(Country));
            select.SelectByIndex(1);
            logger.Info($"Choosing a country");
            AllureHelper.ScreenShot();
            var random = new Random();
            var Digit = random.Next(1, 7);
            var selectState = new SelectElement(driver.FindElement(State));
            selectState.SelectByIndex(Digit);
            logger.Info($"Choosing a state");
            AllureHelper.ScreenShot();
            var user = UserBuilder.GetDataUserForRegistration();
            logger.Info($"Getting a new user");
            driver.FindElement(FirstName).SendKeys(user.FirstName);
            logger.Info($"Input FirstName");
            AllureHelper.ScreenShot();
            driver.FindElement(LastName).SendKeys(user.LastName);
            logger.Info($"Input LastName");
            AllureHelper.ScreenShot();
            driver.FindElement(Address).SendKeys(user.Address);
            logger.Info($"Input Address");
            AllureHelper.ScreenShot();
            driver.FindElement(Zip).SendKeys(user.Zip);
            logger.Info($"Input Zip");
            AllureHelper.ScreenShot();
            driver.FindElement(City).SendKeys(user.City);
            logger.Info($"Input City");
            AllureHelper.ScreenShot();
            driver.FindElement(Homephone).SendKeys(user.Homephone);
            logger.Info($"Input Homephone");
            AllureHelper.ScreenShot();
            driver.FindElement(Mobilephone).SendKeys(user.Mobilephone);
            logger.Info($"Input Mobilephone");
            AllureHelper.ScreenShot();
            driver.FindElement(addressTitle).SendKeys(user.AddressTitle);
            logger.Info($"Input AddressTitle");
            AllureHelper.ScreenShot();
            driver.FindElement(SaveAndContinue).Click();
            logger.Info($"Click on button SaveAndContinue");
            AllureHelper.ScreenShot();


            return new RegistrationPage();
        }

        public override BasePage OpenPage()
        {
            driver.Navigate().GoToUrl(URL);
            logger.Info($"Open page{URL}");
            AllureHelper.ScreenShot();
            return this;
        }
    }
}

