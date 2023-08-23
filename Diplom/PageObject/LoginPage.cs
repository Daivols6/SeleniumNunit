using DIPLOM.Diplom.Core;
using DIPLOM.Diplom.Core.Configuration;
using NUnit.Allure.Attributes;
using NUnit.Framework;
using OpenQA.Selenium;

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
            return this;
        }
        [AllureStep("Standard user authorization")]
        //Авторизация заранее зарегистрированным пользователем
        public LoginPage LoginAsStandartUser()
        {
            driver.FindElement(UserNameInput).SendKeys(UserBuilder.GetStandartUser().Name);
            logger.Info($"Input Standard user name");
            driver.FindElement(PasswordInput).SendKeys(UserBuilder.GetStandartUser().Password);
            logger.Info($"Input Standard user Password");
            logger.Info($"Logining");
            driver.FindElement(LoginButton).Click();
            logger.Info($"Check element on page");
            var element = driver.FindElement(By.XPath("//span[text()='Roman Romanov']"));
            Assert.IsTrue(element.Displayed, "Элемент не найден на странице");
            return new LoginPage();
        }
        [AllureStep("Login by a random user")]
        //Попытка авторизации пользователем со случайной почтой и паролем
        public LoginPage RandomUser()
        {
            driver.FindElement(UserNameInput).SendKeys(randomUser.Email);
            logger.Info($"Input random user name");
            driver.FindElement(PasswordInput).SendKeys(randomUser.Password);
            logger.Info($"Input random user password");
            driver.FindElement(LoginButton).Click();
            logger.Info($"Logining");
            logger.Info($"Check element on page");
            // Поиск элемента на старнице.
            var element = driver.FindElement(ErrorMessage);
            Assert.IsTrue(element.Displayed, "Элемент не найден на странице");
            return new LoginPage();
        }
        [AllureStep("Login by a user without a name")]
        //Авторизация пользователем с пустым именем и указанным существующим паролем.
        public LoginPage StandartUserWithoutName()
        {
            driver.FindElement(UserNameInput).SendKeys(UserBuilder.GetStandartUserWithoutName()?.Name);
            logger.Info($"No Input user name");
            driver.FindElement(PasswordInput).SendKeys(UserBuilder.GetStandartUserWithoutName().Password);
            logger.Info($"Input standart user password");
            driver.FindElement(LoginButton).Click();
            logger.Info($"Logining");
            logger.Info($"Check element on page");
            // Поиск элемента на старнице.
            var element = driver.FindElement(ErrorMessage);
            Assert.IsTrue(element.Displayed, "Элемент не найден на странице");
            return new LoginPage();
        }
    }
}
