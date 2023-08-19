using DIPLOM.Diplom.Core.Elements;
using DIPLOM.Diplom.Core;
using Diplom.Diplom.PageObject;
using OpenQA.Selenium;
using NUnit.Allure.Attributes;
using DIPLOM.Diplom.Core.Configuration;

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
        [AllureStep("Открыть страницу авторизации")]
        public override LoginPageWithBaseElement OpenPage()
        {
            driver.Navigate().GoToUrl(url);
            logger.Info($"Open page {url}");
            AllureHelper.ScreenShot();
            return this;
        }

        [AllureStep("Авторизация стандартным пользователем")]
        public LoginPageWithBaseElement LoginToAccount()
        {
            UserName.GetElement().SendKeys(UserBuilder.GetStandartUser().Name);
            logger.Info($"Entering a name");
            AllureHelper.ScreenShot();
            PasswordInput.GetElement().SendKeys(UserBuilder.GetStandartUser().Password);
            logger.Info($"Entering a password");
            AllureHelper.ScreenShot();
            LoginButton.GetElement().Click();
            logger.Info($"Logining");
            AllureHelper.ScreenShot();
            return this;
        }
        [AllureStep("Создание нового случайного пользователя")]
        public LoginPageWithBaseElement CreateNewUser()
        {
            logger.Info($"Open page{url}");
            OpenPage();
            logger.Info($"input email");
            EmailInput.GetElement().SendKeys(UserBuilder.GetRandomUser().Email);
            AllureHelper.ScreenShot();
            CreateAccountButton.GetElement().Click();
            logger.Info($"Click on button Create Account");
            AllureHelper.ScreenShot();
            return this;
        }
      
      
    }
}

