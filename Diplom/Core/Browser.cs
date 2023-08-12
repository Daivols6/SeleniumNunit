using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Interactions;

namespace Diplom.Diplom.Core
{
    public class Browser
    {
        private static Browser instance = null;
        private IWebDriver driver;
        public IWebDriver Driver { get { return driver; } }



        public static Browser Instatce
        {
            get
            {
                if (instance == null)
                {
                    instance = new Browser();
                }
                return instance;
            }
        }

        private Browser()
        {
/*            bool isHeadless = false;*/
            //choose browser
            var isHeadless = bool.Parse(TestContext.Parameters?.Get("Headless"));
            var Wait = int.Parse(TestContext.Parameters?.Get("ImplicityWait"));
            var browser = TestContext.Parameters?.Get("BrowserType");

            switch (browser)
            {
                case "Chrome":
                    if (isHeadless)
                    {
                        ChromeOptions options = new ChromeOptions();
                        options.AddArgument("--headless");
                        options.AddArgument("--disable-gpu");
                        options.AddArgument("--incognito");
                        options.AddArgument("--start-maximized");
                        driver = new ChromeDriver(options);
                    }
                    else
                    {
                        driver = new ChromeDriver();
                    }
                    break;
                case "FireFox":
                    driver = new InternetExplorerDriver();
                    break;
                    default:
                    driver = new ChromeDriver();
                    break;
            }



            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(Wait);
        }
        public void CloseBrowser()
        {
            driver?.Dispose();
            /*   driver?.Quit();*/
            instance = null;
        }

        public void NavigateToUrl(string url)
        {
            driver.Navigate().GoToUrl(url);
        }
        public void AcceptAllert()
        {
            driver.SwitchTo().Alert().Accept();
        }
        public void DissmissAllert()
        {
            driver.SwitchTo().Alert().Dismiss();
        }

        public void SwitchToFrame(IWebElement id)
        {
            driver.SwitchTo().Frame(id);
        }
        public void SwitchToDefault()
        {
            driver.SwitchTo().DefaultContent();
        }        
        public void ContextClickToElement(IWebElement element)
        {
            var action = new Actions(driver)
           .MoveToElement(element)
           .ContextClick()
           .Build();
                action.Perform();
        }
        public object ExecuteScript(string script, object argument = null)
        {
            try
            {
              return  ((IJavaScriptExecutor)driver).ExecuteScript(script, argument);
            }
            catch(Exception) 
            {
                return null;
            }

        }

    }
}
