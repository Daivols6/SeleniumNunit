using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Home_2
{
    public class AddRemoved : BaseTest
    {
        [Test(Description = "Element AddRemove on Page")]
        public void AddRemove()
        {
            var expectedURL = "https://the-internet.herokuapp.com/add_remove_elements/";
            Thread.Sleep(1000);
            driver.FindElement(By.LinkText("Add/Remove Elements")).Click();
            Thread.Sleep(1000);
            Assert.That(driver.Url, Is.EqualTo(expectedURL));
            Thread.Sleep(1000);
        }

        [Test(Description = "Element AddRemove Page")]
        public void ClickAdd()
        {
            Thread.Sleep(1000);
            driver.FindElement(By.LinkText("Add/Remove Elements")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("/html/body/div[2]/div/div/button")).Click();
            Thread.Sleep(1000);
            var actual = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div/button"));
            Thread.Sleep(1000);
            Assert.IsNotNull(actual);
            Thread.Sleep(1000);

        }
        [Test(Description = "Add 2 element and deleted 1 element")]

        public void ElementCount() 
        {
            Thread.Sleep(1000);
            driver.FindElement(By.LinkText("Add/Remove Elements")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("/html/body/div[2]/div/div/button")).Click();
            Thread.Sleep(100);
            driver.FindElement(By.XPath("/html/body/div[2]/div/div/button")).Click();
            Thread.Sleep(100);
            driver.FindElement(By.XPath("//*[@id=\"elements\"]/button[1]")).Click();
            ReadOnlyCollection<IWebElement> elements = driver.FindElements(By.ClassName("added-manually"));
            int countElement = elements.Count;
            Count(countElement, 1);



        }

    }
}
