using Diplom;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Dropdown - Взять все элементы дроп-дауна и проверить их наличие.
Выбрать первый, проверить, что он выбран, выбрать второй, проверить,
что он выбран
i.
Локатор By.id(“dropdown”)*/
namespace Diplom
{
    public class DropDown: BaseTest
    {
        [Test(Description ="DropDownTests")]
        public void CheckLineDropDown()
        {
            driver.FindElement(By.LinkText("Dropdown")).Click();
            SelectElement select = new(driver.FindElement(By.Id("dropdown")));
            select.SelectByIndex(1);
            var option1 = driver.FindElements(By.CssSelector("#dropdown > option:nth-child(2)"));
            select.SelectByText("Option 2");
            var option2 = driver.FindElements(By.CssSelector("#dropdown > option:nth-child(3)"));
            




        }
    }
}
