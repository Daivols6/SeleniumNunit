using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**Sortable Data Tables - Проверить содержимое нескольких (3-5) ячеек
таблицы.Использовать xpath типа //table//tr[1]//td[1] - получение первой
ячейки из первого ряда первой таблицы и так далее*/
namespace Home_2
{
    public class SortableDataTables : BaseTest
    {
        [Test(Description = "SortableDataTables")]
        public void SortableDataTablesTests()
        {
            driver.FindElement(By.LinkText("Sortable Data Tables")).Click();
            var ElementOne = driver.FindElement(By.XPath("/html/body/div[2]/div/div/table[1]/tbody/tr[1]"));
            string elementText = ElementOne.Text;
            var ElementTwo = driver.FindElement(By.XPath("/html/body/div[2]/div/div/table[1]/tbody/tr[1]"));
            string elementText2 = ElementTwo.Text;
            var ElementThree = driver.FindElement(By.XPath("/html/body/div[2]/div/div/table[1]/tbody/tr[1]"));
            string elementText3 = ElementThree.Text;
            Console.WriteLine(elementText,elementText2,elementText3);


        }
    }
}
