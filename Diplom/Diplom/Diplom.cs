
using Bogus;
using Diplom.Diplom;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;



namespace Diplom.SeleniumTests.Diplom
{
    internal class Tests : BaseTests
    {
        [Test]
        public void Login()
        {

            //переменные
            var expectedURL = "http://prestashop.qatestlab.com.ua/ru/";
            var name = new Faker();
            string email = name.Internet.Email("Testof","mail");
          
            //действия - утверждения
            driver.Navigate().GoToUrl("http://prestashop.qatestlab.com.ua/ru/");
            Assert.That(driver.Url, Is.EqualTo(expectedURL));
            Thread.Sleep(1000);
            driver.FindElement(By.ClassName("sf-with-ul")).Click();
            /*WaitHelper.WaitElement(driver, By.ClassName("sf-with-ul"), 1);*/
            Thread.Sleep(1000);
            driver.FindElement(By.ClassName("login")).Click();
            Thread.Sleep(1000);
            var login = driver.FindElement(By.Id("email_create"));
            login.SendKeys(email);
            Thread.Sleep(1000);
            driver.FindElement(By.CssSelector("#SubmitCreate > span")).Click();
            Thread.Sleep(1000);

        }
       /* [Test]
        public void In1put()
        {
            //переменные
            var URL = "http://prestashop.qatestlab.com.ua/ru/";
            //действия - утверждения
            driver.Navigate().GoToUrl(URL);
            driver.FindElement(By.XPath("/html/body/div[2]/div/ul/li[27]/a")).Click();
            Thread.Sleep(1000);
            var input = driver.FindElement(By.TagName("input"));
            input.SendKeys("23");
            Thread.Sleep(1000);
            input.SendKeys(Keys.ArrowUp + Keys.ArrowUp + Keys.Enter);
            Thread.Sleep(1000);
            var text = input.GetAttribute("value");
            Console.WriteLine(text);
        }*/

        [Test]
        public void Input()
        {
            //переменные
            var URL = "https://the-internet.herokuapp.com/";
            //действия - утверждения
            driver.Navigate().GoToUrl(URL);
            driver.FindElement(By.XPath("/html/body/div[2]/div/ul/li[27]/a")).Click();
            Thread.Sleep(1000);
            var input = driver.FindElement(By.TagName("input"));
            input.SendKeys("23");
            Thread.Sleep(1000);
            input.SendKeys(Keys.ArrowUp+ Keys.ArrowUp+ Keys.Enter);
            Thread.Sleep(1000);
            var text = input.GetAttribute("value");
            Console.WriteLine(text);
        }

        [Test]
        public void DropDown()
        {
            //переменные
            var URL = "https://the-internet.herokuapp.com/";
            //действия - утверждения
            driver.Navigate().GoToUrl(URL);
            driver.FindElement(By.LinkText("Dropdown")).Click();
            Thread.Sleep(1000);
            SelectElement select = new(driver.FindElement(By.Id("dropdown")));
            Thread.Sleep(1000);
            select.SelectByText("Option 2");
            Thread.Sleep(1000);
            select.SelectByIndex(1);
        }

        [Test]
        public void CheckBox()
        {
            //переменные
            var URL = "https://the-internet.herokuapp.com/";
            //действия - утверждения
            driver.Navigate().GoToUrl(URL);
            driver.FindElement(By.LinkText("Checkboxes")).Click();
            List<IWebElement> checkBoxes = driver.FindElements(By.TagName("input")).ToList();
            Assert.IsNotEmpty(checkBoxes);
            var CheckBoxOne = checkBoxes[0];
            Thread.Sleep(1000);
            var CheckBoxTwo = checkBoxes[1];
            Thread.Sleep(1000);
/*            CheckBoxOne.Click();
            Thread.Sleep(1000);
            CheckBoxOne.Click();
            Thread.Sleep(1000);*/
            SetCheckBoxState(CheckBoxOne, false);
            SetCheckBoxState(CheckBoxOne, true);
            SetCheckBoxState(CheckBoxOne, true);
            SetCheckBoxState(CheckBoxOne, false);
            Thread.Sleep(1000);
            var enabled = CheckBoxOne.Selected;
            Thread.Sleep(1000);
            var enabled2 = CheckBoxTwo.Selected;
            Thread.Sleep(1000);
            var selectedByAttribute = CheckBoxOne.GetAttribute("checked");
            Thread.Sleep(1000);
            Console.WriteLine(selectedByAttribute);
            Thread.Sleep(1000);
            Console.WriteLine(enabled);
            Thread.Sleep(1000);
            Console.WriteLine(enabled2);
            Thread.Sleep(1000);

            void SetCheckBoxState(IWebElement element, bool flag)
            {
                var selected = element.Selected;

                if(selected == flag)
                {
                    element.Click();
                }
            }

        }


    }
}
