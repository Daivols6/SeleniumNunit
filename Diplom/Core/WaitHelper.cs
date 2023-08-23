using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace DIPLOM.Diplom.Core
{
    internal class WaitHelper
    {
        //Явное ожидание элемента
        public static void WaitElement(WebDriver driver, By by, int time)
        {
            new WebDriverWait(driver, TimeSpan.FromSeconds(time)).Until(element => element.FindElement(by).Text.ToLower());
        }
    }
}
