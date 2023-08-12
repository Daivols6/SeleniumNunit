using Diplom.Diplom.PageObject;
using Diplom.SeleniumTests.Diplom;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPLOM.Diplom.Test
{
    internal class StandartUserWithoutName: BaseTests
    {

        [Test]
        public void LoginStandartUser()
        {
            /*Browser.Instatce.NavigateToUrl("");*/
            new LoginPage()
            .OpenPage()
            .StandartUserWithoutName();
            Thread.Sleep(1000);
        }
    }
}
