using DIPLOM.Diplom.Core.Elements;
using DIPLOM.Diplom.Core;
using Diplom.Diplom.PageObject;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPLOM.Diplom.PageObject
{
    internal class LoginPageWithBaseElement:BasePage
    {

        private BaseElement UserName = new(By.Id("email"));
        private Input PasswordInput = new(By.Id("passwd"));
        private Input EmailInput = new(By.Id("email_create"));
        private Input LoginButton = new(By.Id("SubmitLogin"));
        private Button CreateAccountButton = new(By.Id("SubmitCreate"));
        


        public const string url = "http://prestashop.qatestlab.com.ua/ru/authentication?back=my-account";

        public LoginPageWithBaseElement() : base()
        {
        }
        public override LoginPageWithBaseElement OpenPage()
        {
            driver.Navigate().GoToUrl(url);
            return this;
        }
        public  LoginPageWithBaseElement LoginToAccount()
        {
            UserName.GetElement().SendKeys(UserBuilder.GetStandartUser().Name);
            PasswordInput.GetElement().SendKeys(UserBuilder.GetStandartUser().Password);
            LoginButton.GetElement().Click();
            return this;
        }
        public  LoginPageWithBaseElement CreateNewUser()
        {
            OpenPage();
            EmailInput.GetElement().SendKeys(UserBuilder.GetRandomUser().Email);
            CreateAccountButton.GetElement().Click();
            return this;
        }
      
      
    }
}

