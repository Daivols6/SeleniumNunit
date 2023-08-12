using Diplom.Diplom.Core;
using Diplom.Diplom.PageObject;
using DIPLOM.Diplom;
using DIPLOM.Diplom.Core;
using DIPLOM.Diplom.PageObject;
using Faker;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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


        public string URL = "http://prestashop.qatestlab.com.ua/ru/";


        public RegistrationPage() : base()
        {
        }
        public RegistrationPage LoginAsStandartUser()
        {
            /*            IWebElement stateElement = driver.FindElement(State);*/
            /*            IWebElement countryElement = driver.FindElement(Country);*/

            /*            SelectElement selectState = new SelectElement(stateElement);*/
            /*            SelectElement selectCountry = new SelectElement(countryElement);*/

            var select = new SelectElement(driver.FindElement(Country));
            select.SelectByIndex(0);
            var random = new Random();
            var Digit = random.Next(1, 7);
            var selectState = new SelectElement(driver.FindElement(State));
            selectState.SelectByIndex(Digit);

            driver.FindElement(FirstName).SendKeys(Faker.Name.First());
            driver.FindElement(LastName).SendKeys(Faker.Name.Last());
            driver.FindElement(Address).SendKeys(Faker.Address.StreetAddress());
            driver.FindElement(Zip).SendKeys($"{Faker.RandomNumber.Next(10000,50000)}");
            driver.FindElement(City).SendKeys(Faker.Address.City());
            driver.FindElement(Homephone).SendKeys(Faker.Phone.Number());
            driver.FindElement(Mobilephone).SendKeys(Faker.Phone.Number());
/*            selectState.SelectByIndex(select);
            selectCountry.SelectByIndex(select);*/

            return new RegistrationPage();
        }

        public override BasePage OpenPage()
        {
            driver.Navigate().GoToUrl(URL);
            return this;
        }
    }
}

