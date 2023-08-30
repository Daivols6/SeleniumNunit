using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace DIPLOM.Diplom.Core
{
    internal class WaitHelper
    {
        ///<summary>
        /// Явное ожидание элемента
        ///</summary>
        ///<param name="driver"></param>
        ///<param name="by"></param>
        ///<param name="time"></param>
        public static void WaitElement(WebDriver driver, By by, int time)
        {
            new WebDriverWait(driver, TimeSpan.FromSeconds(time)).Until(element => element.FindElement(by).Text.ToLower());
        }
    }
}
