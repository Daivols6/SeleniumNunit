using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*проверить, что первый чекбокс unchecked, отметить
первый чекбокс, проверить что он checked. Проверить, что второй
чекбокс checked, сделать unheck, проверить, что он unchecked
Локатор By.cssSelector(“[type=checkbox]”)*/
namespace Home_2
{
    public class Checkboxes:BaseTest
    {
        [Test(Description ="Check checkboxes")]
        public void Checkbox()
        {
            Thread.Sleep(1000);
            driver.FindElement(By.LinkText("Checkboxes")).Click();
            Thread.Sleep(1000);
            IWebElement checkbox = (IWebElement)driver.FindElement(By.CssSelector("#checkboxes > input[type=checkbox]:nth-child(1)"));
            Thread.Sleep(1000);
            bool isChecked = checkbox.Selected;
            Thread.Sleep(1000);
            Check(isChecked);
            Thread.Sleep(1000);
            checkbox.Click();
            bool isCheck1 = checkbox.Selected;
            Thread.Sleep(1000);
            Check(isCheck1);
            Thread.Sleep(1000);
            IWebElement checkbox2 = (IWebElement)driver.FindElement(By.CssSelector("#checkboxes > input[type=checkbox]:nth-child(3)"));
            Thread.Sleep(1000);
            bool isChecked2 = checkbox2.Selected;
            Thread.Sleep(1000);
            Check(isChecked2);
            Thread.Sleep(1000);
            checkbox2.Click();
            bool isCheck = checkbox2.Selected;
            Thread.Sleep(1000);
            Check(isCheck);

        }
    }
}
