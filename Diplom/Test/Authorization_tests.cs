using Diplom.Diplom.PageObject;
using DIPLOM.Diplom.Core;
using DIPLOM.Diplom.PageObject;
using NUnit.Framework;

namespace DIPLOM.Diplom.Test
{
    internal class Authorization_tests : BaseTests
    {
        [Test(Description = "Authorization by a pre-created user")]
        public void LoginWithStandartUserWithBaseElement()
        {
            new LoginPageWithBaseElement()
                .OpenPage()
                .LoginToAccount();
        }
        
        [Test(Description = "Authorization without specifying mail, but with an existing password")]
        public void LoginUserWithoutName()
        {
            new LoginPage()
            .OpenPage()
            .StandartUserWithoutName();
        }
        
        [Test(Description = "Attempt to log in with a random email and password")]
        public void RandomUserTest()
        {
            new LoginPage()
            .OpenPage()
            .RandomUser();
        }
        
        [Test(Description = "Login under the user created in advance")]
        public void LoginStandartUser()
        {
            new LoginPage()
            .OpenPage()
            .LoginAsStandartUser();
        }
    }
}
