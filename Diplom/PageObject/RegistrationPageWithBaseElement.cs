using Diplom.Diplom.Core;
using Diplom.Diplom.PageObject;
using DIPLOM.Diplom.Core;
using DIPLOM.Diplom.Core.Configuration;
using DIPLOM.Diplom.Core.Elements;
using DIPLOM.Diplom.PageObject;
using Faker;
using NUnit.Allure.Attributes;
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
        [AllureStep("Registration for new user")]
        public RegistrationPageWithBaseElement NewUser()
        {

            new LoginPageWithBaseElement().CreateNewUser();
            logger.Info($"Create New User");
            AllureHelper.ScreenShot();
            Gender.GetElement().Click();
            AllureHelper.ScreenShot();
            LastName.GetElement().SendKeys(newUser.LastName);
            logger.Info($"Input Last Name");
            AllureHelper.ScreenShot();
            FirstName.GetElement().SendKeys(newUser.FirstName);
            logger.Info($"Input First Name");
            AllureHelper.ScreenShot();
            Password.GetElement().SendKeys(newUser.Password);
            logger.Info($"Input Password");
            AllureHelper.ScreenShot();
            new DropDown().SelectByValue(Days, "2");
            logger.Info($"Choosing a day");
            AllureHelper.ScreenShot();
            new DropDown().SelectByIndexNumber(Months, 4);
            logger.Info($"Choosing a Months ");
            AllureHelper.ScreenShot();
            new DropDown(Years).SelectDivList(31);
            logger.Info($"Choosing a Years");
            AllureHelper.ScreenShot();

            SaveAndContinue.GetElement().Click();

            try
            {
                // Поиск элемента на старнице.
                var element = driver.FindElement(AlertCreateAccount);


                Assert.IsTrue(element.Displayed);
                logger.Info($"Element found on page");
                AllureHelper.ScreenShot();
            }
            catch (NoSuchElementException)
            {
                // Если элемент не найден, то вызываем AssertionException
                Assert.Fail("Элемент не найден на странице");
                logger.Info($"Element not found on page");
                AllureHelper.ScreenShot();
            }
            return new RegistrationPageWithBaseElement();
        }
        [AllureStep]
        public override BasePage OpenPage()
        {
            driver.Navigate().GoToUrl(URL);
            logger.Info($"Open page{URL}");
            AllureHelper.ScreenShot();
            return this;
        }
    }
}

