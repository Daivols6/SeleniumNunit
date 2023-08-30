using Diplom.Diplom.Core;
using DIPLOM.Diplom.Core.Configuration;
using NUnit.Allure.Core;
using NUnit.Framework;

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
            AllureHelper.ScreenShotIfTestFailed();
            Browser.Instatce.CloseBrowser();
        }
    }
}