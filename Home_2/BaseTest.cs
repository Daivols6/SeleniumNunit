using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Home_2

{
    [TestFixture]
    public class BaseTest
    {
       public static void Check(bool check)
        {
            if (check)
            {
                Console.WriteLine("Чекбокс отмечен");
            }
            else
            {
                Console.WriteLine("Чекбокс не отмечен");
            }
        }       
        public static void Count(int countElement, int expectedCount)
        {
            if (countElement == expectedCount)
            {
                Console.WriteLine("Test passed");
            }
            else
            {
                Console.WriteLine("Test failed");
            }
        }

        protected WebDriver driver;

       /* public ChromeDriver Driver { get => driver; set => driver = value; }*/

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/");
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
