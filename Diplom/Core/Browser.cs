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
        {   //Открыть браузер в полном окне с неявным ожиданием, параметры указаны в runsettings
            var isHeadless = bool.Parse(TestContext.Parameters?.Get("Headless") ?? "false");
            var Wait = int.Parse(TestContext.Parameters?.Get("ImplicityWait") ?? "0");
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
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(Wait);
            driver.Manage().Window.Maximize();
        }
        //Закрыть браузер
        public void CloseBrowser()
        {
            driver.Dispose();
            instance = null;
        }
        //Переход на переднанную страницу 
        public void NavigateToUrl(string url)
        {
            driver.Navigate().GoToUrl(url);
        }
        //Подтверждение на всплывающем окне
        public void AcceptAllert()
        {
            driver.SwitchTo().Alert().Accept();
        }
        //Отклонить во всплывающем окне
        public void DissmissAllert()
        {
            driver.SwitchTo().Alert().Dismiss();
        }
        //Переключиться в Iframe
        public void SwitchToFrame(IWebElement id)
        {
            driver.SwitchTo().Frame(id);
        }
        //Возврат на базовую страницу из iframe
        public void SwitchToDefault()
        {
            driver.SwitchTo().DefaultContent();
        }        
        //Метод для наведения мыши на элемент и клик правой кнопкой
        public void ContextClickToElement(IWebElement element)
        {
            var action = new Actions(driver)
           .MoveToElement(element)
           .ContextClick()
           .Build();
                action.Perform();
        }
        //Метод для наведения мыши на элемент и клик левой кнопкой
        public static void ClickToElement(IWebElement element)
        {
            var action = new Actions(Browser.Instatce.driver)
           .MoveToElement(element)
           .Click()
           .Build();
                action.Perform();
        }
        //Метод для наведения мыши на элемент
        public static void MoveToElementOnPage(IWebElement element)
        {
            var action = new Actions(Browser.Instatce.driver)
           .MoveToElement(element);
                action.Perform();
        }
        //Выполнить переданный JS
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
