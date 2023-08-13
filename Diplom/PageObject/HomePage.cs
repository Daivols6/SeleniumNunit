using Diplom.Diplom.Core;
using Diplom.Diplom.PageObject;
using DIPLOM.Diplom.Core;
using DIPLOM.Diplom.Core.Elements;
using Faker;
using NUnit.Framework;
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
        private By AlertCheckoutButton= By.XPath("//*[@id=\"layer_cart\"]/div[1]/div[2]/div[4]/a/span");
        private By AddToCart = By.XPath("//*[@id=\"add_to_cart\"]/button");
        private By AlertIframe = By.XPath("//*[@id=\"homefeatured\"]/li[2]/div/div[1]/div/a[2]/span");

        



        public HomePage() : base()
        {
        }
        public HomePage GoToShoppingCart()
        {

            
            Actions actions = new Actions(driver);
            IWebElement targetElement = driver.FindElement(By.CssSelector(".first-item-of-mobile-line"));
            actions.MoveToElement(targetElement).Perform();
            driver.FindElement(ChooseRandomProduct).Click();
            driver.FindElement(AlertCheckoutButton).Click();
            driver.FindElement(ProceedToCheckout).Click();
            return new HomePage();
        }
        public HomePage LoginAsStandartUserAndAddToCard()
        {
            Actions actions = new Actions(driver);

            IWebElement targetElement = driver.FindElement(By.CssSelector("#homefeatured > li:nth-child(2)"));
            actions.MoveToElement(targetElement).Perform();
            driver.FindElement(AlertIframe).Click();
            IWebElement iframe = Browser.Instatce.Driver.FindElement(By.CssSelector(".fancybox-iframe"));
            Browser.Instatce.SwitchToFrame(iframe); ;
            driver.FindElement(AddToCart).Click();
            return new  HomePage();
        }


        public override BasePage OpenPage()
        {
            driver.Navigate().GoToUrl(LoginPage.url);
            return this;
        }
        public void GoHomePage()
        {
            By Home = By.CssSelector(".banner");
            new BaseElement(Home).GetElement().Click();
        }
    }
}
