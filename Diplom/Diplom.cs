



using Bogus;
using Diplom.Diplom;
using Diplom.Diplom.Core;
using DIPLOM.Diplom.Core;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V113.IndexedDB;
using OpenQA.Selenium.Support.UI;



namespace Diplom.SeleniumTests.Diplom
{
    [TestFixture]
    internal class Tests : BaseTests
    {




        [Test]
        public void AcceptAllert()
        {

            //переменные


            //действия - утверждения
            Browser.Instatce.NavigateToUrl("https://the-internet.herokuapp.com/javascript_alerts");
            Browser.Instatce.Driver.FindElement(By.XPath("(//button)[1]")).Click();
            Thread.Sleep(1000);
        }
/*        [Test]
        public void IFrame()
        {

            //переменные

            
            //действия - утверждения
            Browser.Instatce.NavigateToUrl("https://the-internet.herokuapp.com/iframe");
            Browser.Instatce.SwitchToFrame("mce_0_ifr");
            var text = Browser.Instatce.Driver.FindElement(By.TagName("p"));
            text.Clear();
            text.SendKeys("test input to iFrame");
            var textform = text.Text;
            Browser.Instatce.SwitchToDefault();

        }*/
        [Test]
        public void JavaScriptTestClick()
        {
            Browser.Instatce.NavigateToUrl("https://the-internet.herokuapp.com/javascript_alerts");
            var button = Browser.Instatce.Driver.FindElement(By.XPath("(//button)[1]"));
            button.Click();
            Browser.Instatce.AcceptAllert();

            Browser.Instatce.ExecuteScript("arguments[0].click();",button);
            Thread.Sleep(1000);
        }
        [Test]
        public void Upload()
        {
            Browser.Instatce.NavigateToUrl("https://the-internet.herokuapp.com/upload");
            var file = Browser.Instatce.Driver.FindElement(By.Id("file-upload"));
            file.SendKeys(DirectoryHelper.GetTestDataFolderPath() + "gptgo.jpg");
            var text = Browser.Instatce.Driver.FindElement(By.Id("file-upload")).Text;
            text = Browser.Instatce.Driver.FindElement(By.Id("file-upload")).GetAttribute("value");
        }


        /*  [Test]
          public void Login()
          {

              //переменные
              var expectedURL = "https://the-internet.herokuapp.com/";
              var name = new Faker();
              string email = name.Internet.Email("Testof","mail");

              //действия - утверждения
              Browser.Instatce.Driver.Navigate().GoToUrl("http://prestashop.qatestlab.com.ua/ru/");
              Assert.That(Browser.Instatce.Driver.Url, Is.EqualTo(expectedURL));
              Thread.Sleep(1000);
              Browser.Instatce.Driver.FindElement(By.ClassName("sf-with-ul")).Click();
              *//*WaitHelper.WaitElement(driver, By.ClassName("sf-with-ul"), 1);*//*
              Thread.Sleep(1000);
              Browser.Instatce.Driver.FindElement(By.ClassName("login")).Click();
              Thread.Sleep(1000);
              var login = Browser.Instatce.Driver.FindElement(By.Id("email_create"));
              login.SendKeys(email);
              Thread.Sleep(1000);
              Browser.Instatce.Driver.FindElement(By.CssSelector("#SubmitCreate > span")).Click();
              Thread.Sleep(1000);

          }
         *//* [Test]
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
          }*//*

          [Test]
          public void Input()
          {
              //переменные
              var URL = "https://the-internet.herokuapp.com/";
              //действия - утверждения
              Browser.Instatce.Driver.Navigate().GoToUrl(URL);
              Browser.Instatce.Driver.FindElement(By.XPath("/html/body/div[2]/div/ul/li[27]/a")).Click();
              Thread.Sleep(1000);
              var input = Browser.Instatce.Driver.FindElement(By.TagName("input"));
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
              Browser.Instatce.Driver.Navigate().GoToUrl(URL);
              Browser.Instatce.Driver.FindElement(By.LinkText("Dropdown")).Click();
              Thread.Sleep(1000);
              SelectElement select = new(Browser.Instatce.Driver.FindElement(By.Id("dropdown")));
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
              Browser.Instatce.Driver.Navigate().GoToUrl(URL);
              Browser.Instatce.Driver.FindElement(By.LinkText("Checkboxes")).Click();
              List<IWebElement> checkBoxes = Browser.Instatce.Driver.FindElements(By.TagName("input")).ToList();
              Assert.IsNotEmpty(checkBoxes);
              var CheckBoxOne = checkBoxes[0];
              Thread.Sleep(1000);
              var CheckBoxTwo = checkBoxes[1];
              Thread.Sleep(1000);
  *//*            CheckBoxOne.Click();
              Thread.Sleep(1000);
              CheckBoxOne.Click();
              Thread.Sleep(1000);*//*
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

  */
    }


}

