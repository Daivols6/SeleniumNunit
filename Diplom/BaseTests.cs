﻿using Diplom.Diplom;
using Diplom.Diplom.Core;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Diplom.SeleniumTests.Diplom
{
    public class BaseTests
    {
        /*        protected IWebDriver driver = Browser.Instatce.Driver;*/
        [SetUp]
        public void SetUp()
        {


        }
        [TearDown]
        public void TearDown()
        {
            //refactoring
            Browser.Instatce.CloseBrowser();
        }
    }
}