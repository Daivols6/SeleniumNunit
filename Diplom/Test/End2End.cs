using Diplom.Diplom.PageObject;
using DIPLOM.Diplom.Core;
using DIPLOM.Diplom.PageObject;
using NUnit.Framework;

namespace DIPLOM.Diplom.Test
{
    internal class End2End: BaseTests
    {
        [Test(Description = "Positive test creating a user, adding an item to the cart and ordering")]
        public void End2EndCheckout()
        {
            new LoginPage().OpenPage();
            new RegistrationPageWithBaseElement().NewUser();
            new HomePage().GoHomePage()
                          .GoToShoppingCart();
            new RegistrationPage().EnterAddressforUser();
            new Adresses().Checkout();
            new ShippingPage().AgreeAndCheckout();
            new Payment().ChoisePaymentByCheck()
                         .AgreePayment()
                         .CheckSuccessMessage();
        }
        [Test(Description = "Negative test. When buying in a US country, there are no payment methods")]
        public void End2EndCheckoutUSA()
        {
            new LoginPage().OpenPage();
            new RegistrationPageWithBaseElement().NewUser();
            new HomePage().GoHomePage()
                          .GoToShoppingCart();
            new RegistrationPage().EnterAddressUSAforUser();
            new Adresses().Checkout();
            new ShippingPage().AgreeAndCheckout();
            new Payment().CheckErrorMessage();
        }
    }
}
