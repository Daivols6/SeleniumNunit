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
    internal class AddToCard
    {
        [Test]
        public void AddCard()
        {
            new LoginPage()
                .OpenPage();
            new HomesPage().Go();
        }
    }
}
