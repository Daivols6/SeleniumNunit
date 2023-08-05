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
    internal class ErrorUser: BaseTests
    {
        [Test]
        public void ErrorUserTest()
        {
            new LoginPage(driver)
            .OpenPage()
            .ErrorUser();
        }
    }
}
