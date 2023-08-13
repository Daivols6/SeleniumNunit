using Diplom.Diplom.PageObject;
using DIPLOM.Diplom.Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

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
        public RegistrationPage EnterAddressforUser()
        {


            var select = new SelectElement(driver.FindElement(Country));
            select.SelectByIndex(0);
            var random = new Random();
            var Digit = random.Next(1, 7);
            var selectState = new SelectElement(driver.FindElement(State));
            selectState.SelectByIndex(Digit);
            var user = UserBuilder.GetDataUserForRegistration();
            driver.FindElement(FirstName).SendKeys(user.FirstName);
            driver.FindElement(LastName).SendKeys(user.LastName);
            driver.FindElement(Address).SendKeys(user.Address);
            driver.FindElement(Zip).SendKeys(user.Zip);
            driver.FindElement(City).SendKeys(user.City);
            driver.FindElement(Homephone).SendKeys(user.Homephone);
            driver.FindElement(Mobilephone).SendKeys(user.Mobilephone);
            driver.FindElement(addressTitle).SendKeys(user.AddressTitle);
            driver.FindElement(SaveAndContinue).Click();


            return new RegistrationPage();
        }

        public override BasePage OpenPage()
        {
            driver.Navigate().GoToUrl(URL);
            return this;
        }
    }
}

