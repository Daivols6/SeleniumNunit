using Diplom.Diplom.PageObject;
using DIPLOM.Diplom.Core;
using DIPLOM.Diplom.PageObject;
using NUnit.Framework;

namespace DIPLOM.Diplom.Test
{
    internal class Tests_for_adding_an_item_to_the_cart : BaseTests
    {
        [Test(Description = "Logging in by an existing user and adding an item to the cart")]
        public void AddCard()
        {
            new LoginPage().OpenPage()
                .LoginAsStandartUser();
            new HomePage()
                .GoHomePage()
                .AddToCard();
        }
    }
}
