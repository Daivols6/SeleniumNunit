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
    internal class RegistrationTest : BaseTests
    {
        [Test]
        public void Registration()
        {
            /*Browser.Instatce.NavigateToUrl("");*/
            new LoginPage()
            .OpenPage()
            .LoginAsStandartUser();
            
        }
    }
}
