using Diplom.Diplom.Core;
using Diplom.Diplom.PageObject;
using DIPLOM.Diplom.Core;
using DIPLOM.Diplom.Core.Elements;
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
    internal class RegistrationPageWithBaseElement: BasePage
    {

        private Input Password = new(By.Id("passwd"));
        private Input Gender = new(By.Id("uniform-id_gender2"));
        private Input LastName = new(By.Id("customer_lastname"));
        private Input FirstName = new(By.Id("customer_firstname"));
        private DropDown State = new(By.XPath("//*[@id='id_state']"));
        private By AlertCreateAccount = By.CssSelector(".alert-success");
        private By Days = By.Id("days");
        private By Months = By.Id("months");
        private By Years = By.Id("cuselFrame-years");
        private Button SaveAndContinue = new(By.Id("submitAccount"));
        private UserModel newUser = UserBuilder.GetNewUser();
        


        public string URL = "http://prestashop.qatestlab.com.ua/ru/authentication?back=my-account#account-creation";


        public RegistrationPageWithBaseElement() : base()
        {
        }
        public RegistrationPageWithBaseElement NewUser()
        {
            new LoginPageWithBaseElement()
                .CreateNewUser();
            Gender.GetElement().Click();
            LastName.GetElement().SendKeys(newUser.LastName);
            FirstName.GetElement().SendKeys(newUser.FirstName);
            Password.GetElement().SendKeys(newUser.Password);
            new DropDown().SelectByValue(Days,"2");
            new DropDown().SelectByIndexNumber(Months, 4);
            new DropDown(Years).SelectDivList(31);

            SaveAndContinue.GetElement().Click();
            try
            {
                // Поиск элемента на старнице.
                var element = driver.FindElement(AlertCreateAccount);
                var displayed = element.Displayed;
                Assert.IsNotNull(displayed);
            }
            catch (NoSuchElementException)
            {
                // Если элемент не найден, то вызываем AssertionException
                Assert.Fail("Элемент не найден на странице");
            }
            return new RegistrationPageWithBaseElement();
        }

        public override BasePage OpenPage()
        {
            driver.Navigate().GoToUrl(URL);
            return this;
        }
    }
}

