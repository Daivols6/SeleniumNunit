using Diplom.Diplom.PageObject;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPLOM.Diplom.Test
{
    internal class RegistrationTest
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
