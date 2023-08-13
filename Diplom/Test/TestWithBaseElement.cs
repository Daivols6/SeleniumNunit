using Diplom.Diplom.PageObject;
using DIPLOM.Diplom.Core;
using DIPLOM.Diplom.PageObject;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPLOM.Diplom.Test
{
    internal class TestWithBaseElement : BaseTests
    {
        [Test]
        public void LoginWithStandartUser()
        {
            new LoginPageWithBaseElement()
                .OpenPage()
                .LoginToAccount();
        }
    }
}
