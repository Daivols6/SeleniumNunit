using Diplom.Diplom.PageObject;
using DIPLOM.Diplom.PageObject;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPLOM.Diplom.Test
{
    internal class E2E
    {
        [Test]
        public void End2End()
        {
            new LoginPage()
                .OpenPage();
            new HomePage().GoToShoppingCart();
        }
    }
}
