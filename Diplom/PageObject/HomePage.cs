using Diplom.Diplom.Core;
using Diplom.Diplom.PageObject;
using DIPLOM.Diplom.Core;
using DIPLOM.Diplom.Core.Configuration;
using DIPLOM.Diplom.Core.Elements;
using Faker;
using NUnit.Allure.Attributes;
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
        private By ChooseProduct = By.XPath($"//*[@id=\"homefeatured\"]/li[1]/div/div[2]/div[2]/a[1]/span");
        private By ProceedToCheckout = By.XPath("//*[@id=\"center_column\"]/p[2]/a");
        private By AlertCheckoutButton= By.XPath("//*[@id=\"layer_cart\"]/div[1]/div[2]/div[4]/a/span");
        private By AddToCart = By.XPath("//*[@id=\"add_to_cart\"]/button");
        private By AlertIframe = By.XPath("//*[@id=\"homefeatured\"]/li[2]/div/div[1]/div/a[2]/span");
        private By Home = By.CssSelector(".banner");
        public HomePage() : base()
        {
        }
        
        [AllureStep]
        public HomePage GoToShoppingCart()
        {            
            Actions actions = new Actions(driver);
            IWebElement targetElement = driver.FindElement(By.CssSelector(".first-item-of-mobile-line"));
            actions.MoveToElement(targetElement).Perform();
            logger.Info($"Click on Qick View");
            AllureHelper.ScreenShot();
            driver.FindElement(ChooseProduct).Click();
            logger.Info($"ChooseProduct");
            AllureHelper.ScreenShot();
            driver.FindElement(AlertCheckoutButton).Click();
            logger.Info($"Click on Checkout Button ");
            AllureHelper.ScreenShot();
            driver.FindElement(ProceedToCheckout).Click();
            logger.Info($"Click on Proceed To Checkout ");
            AllureHelper.ScreenShot();
            return new HomePage();
        }
        [AllureStep]
        public HomePage LoginAsStandartUserAndAddToCard()
        {
            Actions actions = new Actions(driver);

            IWebElement targetElement = driver.FindElement(By.CssSelector("#homefeatured > li:nth-child(2)"));
            actions.MoveToElement(targetElement).Perform();
            AllureHelper.ScreenShot();
            driver.FindElement(AlertIframe).Click();
            AllureHelper.ScreenShot();
            IWebElement iframe = Browser.Instatce.Driver.FindElement(By.CssSelector(".fancybox-iframe"));
            Browser.Instatce.SwitchToFrame(iframe);
            logger.Info($"Click on buuton in Iframe");
            AllureHelper.ScreenShot();
            driver.FindElement(AddToCart).Click();
            logger.Info($"Product add to cart");
            AllureHelper.ScreenShot();
            return new  HomePage();
        }

        [AllureStep]
        public override BasePage OpenPage()
        {
            driver.Navigate().GoToUrl(LoginPage.url);
            logger.Info($"Open page {LoginPage.url}");
            return this;
        }
        [AllureStep("Переход на домашнюю страницу")]
        public HomePage GoHomePage()
        {
            new BaseElement(Home).GetElement().Click();
            logger.Info($"Go to the home page");
            AllureHelper.ScreenShot();
            return new HomePage();
        }
    }
}
