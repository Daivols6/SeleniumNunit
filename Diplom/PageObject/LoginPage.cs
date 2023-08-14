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
        private static Logger logger = LogManager.GetCurrentClassLogger();
        private UserModel randomUser = UserBuilder.GetRandomUser();

        public const string url = "http://prestashop.qatestlab.com.ua/ru/authentication";

        public LoginPage() : base()
        {
        }
        [AllureStep("Открытие страницы")]
        public override LoginPage OpenPage()
        {
            logger.Info($"Navigate to url {url} ");
            driver.Navigate().GoToUrl(url);
            return this;
        }
        /*        public void ClickToLogin()
                {
                    UserName.ElementGet.Click();
                }*/
        [AllureStep("Залогин стандартным пользователем")]
        public LoginPage LoginAsStandartUser()
        {            
            driver.FindElement(UserNameInput).SendKeys(UserBuilder.GetStandartUser().Name);
            AllureHelper.ScreenShot();
            driver.FindElement(PasswordInput).SendKeys(UserBuilder.GetStandartUser().Password);
            AllureHelper.ScreenShot();
            driver.FindElement(LoginButton).Click();
            try
            {
                // Попробуйте найти элемент с помощью XPath
                var element = driver.FindElement(By.XPath("//span[text()='Roman Romanov']"));
                AllureHelper.ScreenShot();
            }
            catch (NoSuchElementException)
            {
                // Если элемент не найден, то вызываем AssertionException
                Assert.Fail("Элемент не найден на странице");
                AllureHelper.ScreenShot();
            }
            return new LoginPage();
        }
        [AllureStep("Залогин случайным пользователем")]
        public LoginPage RandomUser()
        {        

            driver.FindElement(UserNameInput).SendKeys(randomUser.Email);
            AllureHelper.ScreenShot();
            driver.FindElement(PasswordInput).SendKeys(randomUser.Password);
            AllureHelper.ScreenShot();
            driver.FindElement(LoginButton).Click();
            AllureHelper.ScreenShot();
            try
            {
                // Поиск элемента на старнице.
                var element = driver.FindElement(ErrorMessage);
                var displayed = element.Displayed;
                Assert.IsNotNull(displayed);
                AllureHelper.ScreenShot();
            }
            catch (NoSuchElementException)
            {
                // Если элемент не найден, то вызываем AssertionException
                Assert.Fail("Элемент не найден на странице");
                AllureHelper.ScreenShot();
            }
            return new LoginPage();
        }
        [AllureStep("Залогин пользователем без имени")]
        public LoginPage StandartUserWithoutName()
        {
            driver.FindElement(UserNameInput).SendKeys(UserBuilder.GetStandartUserWithoutName()?.Name);
            AllureHelper.ScreenShot();
            driver.FindElement(PasswordInput).SendKeys(UserBuilder.GetStandartUserWithoutName().Password);
            AllureHelper.ScreenShot();
            driver.FindElement(LoginButton).Click();
            try
            {
                // Поиск элемента на старнице.
                var element = driver.FindElement(ErrorMessage);
                var displayed = element.Displayed;
                Assert.IsNotNull(displayed);
                AllureHelper.ScreenShot();
            }
            catch (NoSuchElementException)
            {
                // Если элемент не найден, то вызываем AssertionException
                Assert.Fail("Элемент не найден на странице");
                AllureHelper.ScreenShot();
            }
            return new LoginPage();
        }
    }
}
