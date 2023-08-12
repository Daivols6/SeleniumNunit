using Diplom.Diplom.PageObject;
using DIPLOM.Diplom.Core;
using Faker;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPLOM.Diplom.PageObject
{
    internal class HomePage:BasePage
    {
        private By ChooseRandomProduct = By.XPath($"//*[@id=\"homefeatured\"]/li[1]/div/div[2]/div[2]/a[1]/span");
        private By ProceedToCheckout = By.XPath("//*[@id=\"center_column\"]/p[2]/a");
        private By Alert= By.XPath("//*[@id=\"layer_cart\"]/div[1]/div[2]/div[4]/a/span");
        private By Logout = By.ClassName("logout");
        private By Account = By.ClassName("account");
        private By ShoppingCart = By.ClassName("shopping_cart");
        private By GoToHomePage = By.ClassName("img-responsive");

        

       /* private static int selectedProduct = new Random().Next(1, 5);*/

        public HomePage() : base()
        {
        }
        public HomePage GoToShoppingCart()
        {
            Actions actions = new Actions(driver);
            
            new LoginPage().LoginAsStandartUser();
            driver.FindElement(GoToHomePage).Click();
            IWebElement targetElement = driver.FindElement(By.CssSelector(".first-item-of-mobile-line"));
            actions.MoveToElement(targetElement).Perform();
            driver.FindElement(ChooseRandomProduct).Click();
            driver.FindElement(Alert).Click();
/*            driver.FindElement(ShoppingCart).Click();*/
            driver.FindElement(ProceedToCheckout).Click();
            new RegistrationPage().LoginAsStandartUser();

            Thread.Sleep(5000);
            return new HomePage();
        }

        public override BasePage OpenPage()
        {
            driver.Navigate().GoToUrl(LoginPage.url);
            return this;
        }
    }
}
