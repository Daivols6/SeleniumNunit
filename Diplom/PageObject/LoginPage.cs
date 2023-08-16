using DIPLOM.Diplom.Core;
using DIPLOM.Diplom.Core.Configuration;
using DIPLOM.Diplom.Core.Elements;
using NLog;
using NUnit.Allure.Attributes;
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
        private UserModel randomUser = UserBuilder.GetRandomUser();

        public const string url = "http://prestashop.qatestlab.com.ua/ru/authentication";

        public LoginPage() : base()
        {
        }
        [AllureStep("Opening the authorization page")]
        public override LoginPage OpenPage()
        {
            logger.Info($"Navigate to url {url} ");
            driver.Navigate().GoToUrl(url);
            AllureHelper.ScreenShot();
            return this;
        }

        [AllureStep("Standard user authorization")]
        public LoginPage LoginAsStandartUser()
        {
            ;
            driver.FindElement(UserNameInput).SendKeys(UserBuilder.GetStandartUser().Name);
            logger.Info($"Input Standard user name");
            AllureHelper.ScreenShot();
            driver.FindElement(PasswordInput).SendKeys(UserBuilder.GetStandartUser().Password);
            logger.Info($"Input Standard user Password");
            AllureHelper.ScreenShot();
            logger.Info($"Logining");
            driver.FindElement(LoginButton).Click();
            try
            {
                logger.Info($"Check element on page");
                var element = driver.FindElement(By.XPath("//span[text()='Roman Romanov']"));
                AllureHelper.ScreenShot();
            }
            catch (NoSuchElementException)
            {
                logger.Info($"element not found");
                Assert.Fail("Элемент не найден на странице");
                AllureHelper.ScreenShot();
            }
            return new LoginPage();
        }
        [AllureStep("Login by a random user")]
        public LoginPage RandomUser()
        {

            driver.FindElement(UserNameInput).SendKeys(randomUser.Email);
            logger.Info($"Input random user name");
            AllureHelper.ScreenShot();
            driver.FindElement(PasswordInput).SendKeys(randomUser.Password);
            logger.Info($"Input random user password");
            AllureHelper.ScreenShot();
            driver.FindElement(LoginButton).Click();
            logger.Info($"Logining");
            AllureHelper.ScreenShot();
            try
            {
                logger.Info($"Check element on page");
                // Поиск элемента на старнице.
                var element = driver.FindElement(ErrorMessage);
                var displayed = element.Displayed;
                Assert.IsNotNull(displayed);
                AllureHelper.ScreenShot();
            }
            catch (NoSuchElementException)
            {
                logger.Info($"element not found");
                // Если элемент не найден, то вызываем AssertionException
                Assert.Fail("Элемент не найден на странице");
                AllureHelper.ScreenShot();
            }
            return new LoginPage();
        }
        [AllureStep("Login by a user without a name")]
        public LoginPage StandartUserWithoutName()
        {
            driver.FindElement(UserNameInput).SendKeys(UserBuilder.GetStandartUserWithoutName()?.Name);
            logger.Info($"No Input user name");
            AllureHelper.ScreenShot();
            driver.FindElement(PasswordInput).SendKeys(UserBuilder.GetStandartUserWithoutName().Password);
            logger.Info($"Input standart user password");
            AllureHelper.ScreenShot();
            driver.FindElement(LoginButton).Click();
            logger.Info($"Logining");
            try
            {
                logger.Info($"Check element on page");
                // Поиск элемента на старнице.
                var element = driver.FindElement(ErrorMessage);
                var displayed = element.Displayed;
                Assert.IsNotNull(displayed);
                AllureHelper.ScreenShot();
            }
            catch (NoSuchElementException)
            {
                logger.Info($"element not found");
                // Если элемент не найден, то вызываем AssertionException
                Assert.Fail("Элемент не найден на странице");
                AllureHelper.ScreenShot();
            }
            return new LoginPage();
        }
    }
}
