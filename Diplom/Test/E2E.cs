using Diplom.Diplom.PageObject;
using DIPLOM.Diplom.Core;
using DIPLOM.Diplom.PageObject;
using NUnit.Allure.Attributes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPLOM.Diplom.Test
{
    internal class E2E:BaseTests
    {
        [Test]

        public void End2EndCheckout()
        {
            new LoginPage().OpenPage();
            new RegistrationPageWithBaseElement().NewUser();
            /*new LoginPage().LoginAsStandartUser();*/
            new HomePage().GoHomePage();
            new HomePage().GoToShoppingCart();
            new RegistrationPage().EnterAddressforUser();
            new Adresses().Checkout();
            new ShippingPage().AgreeAndCheckout();


        }
    }
}
