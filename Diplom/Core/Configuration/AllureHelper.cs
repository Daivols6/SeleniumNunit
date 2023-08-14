using Allure.Commons;
using Diplom.Diplom.Core;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPLOM.Diplom.Core.Configuration
{
    internal class AllureHelper
    {
        private static AllureLifecycle allure = AllureLifecycle.Instance;

        public static void ScreenShot()
        {
            Screenshot screenshot = ((ITakesScreenshot)Browser.Instatce.Driver).GetScreenshot();
            byte[] bytes = screenshot.AsByteArray;
            allure.AddAttachment("Screenshot", "image/png", bytes);
        }
    }
}
