using Diplom.Diplom.Core;
using Diplom.Diplom.PageObject;
using DIPLOM.Diplom.Core.Configuration;
using DIPLOM.Diplom.Core.Elements;
using NUnit.Allure.Attributes;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System.Xml.Linq;

namespace DIPLOM.Diplom.PageObject
{
    internal class HomePage : BasePage
    {
        private By ChooseProduct = By.XPath($"//*[@id=\"homefeatured\"]/li[1]/div/div[2]/div[2]/a[1]/span");
        private By ProceedToCheckout = By.XPath("//*[@id=\"center_column\"]/p[2]/a");
        private By AlertCheckoutButton = By.XPath("//*[@id=\"layer_cart\"]/div[1]/div[2]/div[4]/a/span");
        private By AddToCart = By.XPath("//*[@id=\"add_to_cart\"]/button");
        private By AlertIframe = By.XPath("//*[@id=\"homefeatured\"]/li[2]/div/div[1]/div/a[2]/span");
        private By AddToCardButton = By.CssSelector(".button-medium");
        private By Home = By.CssSelector(".banner");
        
        public HomePage() : base()
        {
        }
        
        ///<summary>
        /// Добавление товара в корзину через кнопку AddToCard и переход к оформлению заказа
        ///</summary>
        /// <returns></returns>
        [AllureStep]
        public HomePage GoToShoppingCart()
        {
            IWebElement Product = driver.FindElement(By.CssSelector(".first-item-of-mobile-line"));
            Browser.MoveToElementOnPage(Product);
            logger.Info($"Click on Qick View");
            driver.FindElement(ChooseProduct).Click();
            logger.Info($"ChooseProduct");
            driver.FindElement(AlertCheckoutButton).Click();
            logger.Info($"Click on Checkout Button ");
            driver.FindElement(ProceedToCheckout).Click();
            logger.Info($"Click on Proceed To Checkout ");

            return new HomePage();
        }

        ///<summary>
        /// Добавление товара в корзину через наведение на товар нажатие QuickView, переход в Iframe и нажатие кнопки AddToCard
        ///</summary>
        /// <returns></returns>
        [AllureStep]
        public HomePage AddToCard()
        {
            IWebElement QuickView = Browser.Instatce.Driver.FindElement(By.CssSelector("#homefeatured > li:nth-child(2)"));
            Browser.MoveToElementOnPage(QuickView);
            logger.Info($"Hover and click on the product");
            driver.FindElement(AlertIframe).Click();
            IWebElement iframe = Browser.Instatce.Driver.FindElement(By.CssSelector(".fancybox-iframe"));
            Browser.Instatce.SwitchToFrame(iframe);
            logger.Info($"Click on buuton in Iframe");
            driver.FindElement(AddToCart).Click();
            logger.Info($"Product add to cart");
            Assert.IsTrue(CheckElementOnPage(AddToCardButton), "Элемент не найден на странице");
            return new HomePage();
        }
        
        [AllureStep]
        public override BasePage OpenPage()
        {
            driver.Navigate().GoToUrl(LoginPage.url);
            logger.Info($"Open page {LoginPage.url}");
            return this;
        }

        ///<summary>
        ///Возврат на домашнюю страницу
        ///</summary>
        /// <returns></returns>
        [AllureStep("Переход на домашнюю страницу")]
        public HomePage GoHomePage()
        {
            new BaseElement(Home).GetElement().Click();
            logger.Info($"Go to the home page");
            return new HomePage();
        }
    }
}
