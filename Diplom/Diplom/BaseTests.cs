using Diplom.Diplom;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Diplom.SeleniumTests.Diplom
{
    public class BaseTests
    {
        protected static WebDriver driver;
        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Navigate().GoToUrl("http://prestashop.qatestlab.com.ua/ru/");

        }
        [TearDown]
        public void TearDown()
        {
            Thread.Sleep(1000);
            driver.Quit();
        }
    }
}