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
    internal class AddToCard : BaseTests
    {
        [Test]
        public void AddCard()
        {
            new LoginPage().OpenPage()
                .LoginAsStandartUser();
            var Home = new HomePage();
            Home.GoHomePage();
            Home.LoginAsStandartUserAndAddToCard();
            Home.GoHomePage();




        }
    }
}
