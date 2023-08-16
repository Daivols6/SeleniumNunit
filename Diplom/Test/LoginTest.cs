using Diplom.Diplom.Core;
using Diplom.Diplom.PageObject;
using DIPLOM.Diplom.Core;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPLOM.Diplom.Test
{
    internal class LoginTest : BaseTests
    {
        [Test]
        public void LoginStandartUser()
        {
            new LoginPage()
            .OpenPage()
            .LoginAsStandartUser();
            Thread.Sleep(1000);
        }
    }
}
