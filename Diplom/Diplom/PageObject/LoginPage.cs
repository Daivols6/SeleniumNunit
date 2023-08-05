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

        public const string url = "http://prestashop.qatestlab.com.ua/ru/authentication";
        public const string Standart_user_name = "testRoman@email.ru";
        public const string Standart_user_password = "12345";
        public LoginPage(WebDriver webDriver) : base(webDriver)
        {
        }
        public override LoginPage OpenPage()
        {
            driver.Navigate().GoToUrl(url);
            return this;
        }
        public LoginPage LoginAsStandartUser()
        {
            driver.FindElement(UserNameInput).SendKeys(Standart_user_name);
            driver.FindElement(PasswordInput).SendKeys(Standart_user_password);
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
            return new LoginPage(driver);
        }

        public LoginPage ErrorUser()
        {
            driver.FindElement(UserNameInput).SendKeys("testRoman@em.dd");
            driver.FindElement(PasswordInput).SendKeys("12345");
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
            return new LoginPage(driver);
        }
    }
}
