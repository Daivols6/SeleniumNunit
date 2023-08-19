using Allure.Commons;
using Diplom.Diplom;
using Diplom.Diplom.Core;
using DIPLOM.Diplom.Core.Configuration;
using NUnit.Allure.Core;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace DIPLOM.Diplom.Core
{
    [AllureNUnit]

    public class BaseTests
    {
       


        [OneTimeSetUp]
        public void SetUp()
        {

            
        }

        [TearDown]
        public void TearDown()
        {
            AllureHelper.ScreenShot();

            Browser.Instatce.CloseBrowser();
        }
    }
}