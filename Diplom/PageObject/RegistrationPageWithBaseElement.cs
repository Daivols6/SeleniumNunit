using Diplom.Diplom.PageObject;
using DIPLOM.Diplom.Core;
using DIPLOM.Diplom.Core.Configuration;
using DIPLOM.Diplom.Core.Elements;
using NUnit.Allure.Attributes;
using NUnit.Framework;
using OpenQA.Selenium;

namespace DIPLOM.Diplom.PageObject
{
    internal class RegistrationPageWithBaseElement : BasePage
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
        //Заполнение данных на странице "YOUR PERSONAL INFORMATION"
        public RegistrationPageWithBaseElement NewUser()
        {
            new LoginPageWithBaseElement().CreateNewUser();
            logger.Info($"Create New User");
            Gender.GetElement().Click();
            LastName.GetElement().SendKeys(newUser.LastName);
            logger.Info($"Input Last Name");
            FirstName.GetElement().SendKeys(newUser.FirstName);
            logger.Info($"Input First Name");
            Password.GetElement().SendKeys(newUser.Password);
            logger.Info($"Input Password");
            new DropDown().SelectByValue(Days, "2");
            logger.Info($"Choosing a day");
            new DropDown().SelectByIndexNumber(Months, 4);
            logger.Info($"Choosing a Months ");
            new DropDown(Years).SelectDivList(31);
            logger.Info($"Choosing a Years");
            SaveAndContinue.GetElement().Click();
            var element = driver.FindElement(AlertCreateAccount);
            Assert.IsTrue(element.Displayed, "Элемент не найден на странице");
            logger.Info($"Element found on page");
            return new RegistrationPageWithBaseElement();
        }
        [AllureStep]
        public override BasePage OpenPage()
        {
            driver.Navigate().GoToUrl(URL);
            logger.Info($"Open page{URL}");
            return this;
        }
    }
}

