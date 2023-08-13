using DIPLOM.Diplom.Core;
using DIPLOM.Diplom.Core.Elements;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom.Diplom.PageObject
{
    internal class LoginPage : BasePage
    {

        private By UserNameInput = By.Id("email");
        private By PasswordInput = By.Id("passwd");
        private By ErrorMessage = By.CssSelector(".alert-danger");
        private By LoginButton = By.CssSelector(".icon-lock");
        private By Logout = By.ClassName("logout");
        private By Account = By.ClassName("account");
        private By ShoppingCart = By.ClassName("shopping_cart");

        public const string url = "http://prestashop.qatestlab.com.ua/ru/authentication";

        public LoginPage() : base()
        {
        }
        public override LoginPage OpenPage()
        {
            driver.Navigate().GoToUrl(url);
            return this;
        }
/*        public void ClickToLogin()
        {
            UserName.ElementGet.Click();
        }*/
        public LoginPage LoginAsStandartUser()
        {
            driver.FindElement(UserNameInput).SendKeys(UserBuilder.GetStandartUser().Name);
            driver.FindElement(PasswordInput).SendKeys(UserBuilder.GetStandartUser().Password);
            driver.FindElement(LoginButton).Click();
            try
            {
                // Попробуйте найти элемент с помощью XPath
                var element = driver.FindElement(By.XPath("//span[text()='Roman Romanov']"));
            }
            catch (NoSuchElementException)
            {
                // Если элемент не найден, то вызываем AssertionException
                Assert.Fail("Элемент не найден на странице");
            }
            return new LoginPage();
        }

        public LoginPage RandomUser()
        {
            driver.FindElement(UserNameInput).SendKeys(UserBuilder.GetRandomUser().Name);
            driver.FindElement(PasswordInput).SendKeys(UserBuilder.GetRandomUser().Password);
            driver.FindElement(LoginButton).Click();
            try
            {
                // Поиск элемента на старнице.
                var element = driver.FindElement(ErrorMessage);
                var displayed = element.Displayed;
                Assert.IsNotNull(displayed);
            }
            catch (NoSuchElementException)
            {
                // Если элемент не найден, то вызываем AssertionException
                Assert.Fail("Элемент не найден на странице");
            }
            return new LoginPage();
        }

        public LoginPage StandartUserWithoutName()
        {
            driver.FindElement(UserNameInput).SendKeys(UserBuilder.GetStandartUserWithoutName()?.Name);
            driver.FindElement(PasswordInput).SendKeys(UserBuilder.GetStandartUserWithoutName().Password);
            driver.FindElement(LoginButton).Click();
            try
            {
                // Поиск элемента на старнице.
                var element = driver.FindElement(ErrorMessage);
                var displayed = element.Displayed;
                Assert.IsNotNull(displayed);
            }
            catch (NoSuchElementException)
            {
                // Если элемент не найден, то вызываем AssertionException
                Assert.Fail("Элемент не найден на странице");
            }
            return new LoginPage();
        }
    }
}
