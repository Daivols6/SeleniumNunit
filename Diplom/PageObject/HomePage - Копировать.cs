using Diplom.Diplom.Core;
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
    internal class HomesPage:BasePage
    {
        private By ChooseRandomProduct = By.XPath($"//*[@id=\"homefeatured\"]/li[1]/div/div[2]/div[2]/a[1]/span");
        private By ProceedToCheckout = By.XPath("//*[@id=\"add_to_cart\"]/button");
        private By Alert= By.XPath("//*[@id=\"homefeatured\"]/li[2]/div/div[1]/div/a[2]/span");
        private By Logout = By.ClassName("logout");
        private By Account = By.ClassName("account");
        private By ShoppingCart = By.ClassName("shopping_cart");
        private By GoToHomePage = By.ClassName("img-responsive");
        private IWebElement iframe = Browser.Instatce.Driver.FindElement(By.XPath("//iframe[contains(@class, 'fancybox-iframe')]"));


        /* private static int selectedProduct = new Random().Next(1, 5);*/

        public HomesPage() : base()
        {
        }
        public HomesPage Go()
        {
            Actions actions = new Actions(driver);



            new LoginPage().LoginAsStandartUser();
            driver.FindElement(GoToHomePage).Click();
            IWebElement targetElement = driver.FindElement(By.CssSelector("#homefeatured > li:nth-child(2)"));
            actions.MoveToElement(targetElement).Perform();
            driver.FindElement(Alert).Click();

            Browser.Instatce.SwitchToFrame(iframe); ;
            driver.FindElement(ProceedToCheckout).Click();
            return new HomesPage();
        }

        public override BasePage OpenPage()
        {
            driver.Navigate().GoToUrl(LoginPage.url);
            return this;
        }
    }
}
