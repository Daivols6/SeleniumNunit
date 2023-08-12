using Diplom.Diplom.Core;
using Diplom.Diplom.PageObject;
using Diplom.SeleniumTests.Diplom;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom.Diplom.Test
{
    internal class LoginTest : BaseTests
    {
        [Test]
        public void LoginStandartUser()
        {
            /*Browser.Instatce.NavigateToUrl("");*/
            new LoginPage()
            .OpenPage()
            .LoginAsStandartUser();
            Thread.Sleep(1000);
        }
    }
}
