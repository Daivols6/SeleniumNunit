using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Diplom;

/*Inputs - Проверить на возможность ввести различные цифровые и
нецифровые значения, используя Keys.ARROW_UP И
Keys.ARROW_DOWN
i.
Локатор By.tagName(“input”)*/
namespace Diplom
{
    public class Inputs:BaseTest
    {
        [Test(Description ="InputTests")]
        public void InputTest()
        {
            driver.FindElement(By.LinkText("Inputs")).Click();
            var input = driver.FindElement(By.TagName("input"));
            Thread.Sleep(1000);
            input.SendKeys("100");
            Thread.Sleep(1000);
            input.Clear();
            Thread.Sleep(1000);
            input.SendKeys("50");
            Thread.Sleep(1000);
            input.SendKeys(Keys.ArrowUp + Keys.ArrowUp+ Keys.Enter);
            Thread.Sleep(1000);
            input.Clear();
            Thread.Sleep(1000);
            input.SendKeys("eE");
            Thread.Sleep(1000);
            input.Clear();
            Thread.Sleep(1000);
            input.SendKeys("vwvwvwv232");
            Thread.Sleep(1000);
        }
    }
}
