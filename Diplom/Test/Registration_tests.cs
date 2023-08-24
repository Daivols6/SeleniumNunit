using Allure.Commons;
using Diplom.Diplom.PageObject;
using DIPLOM.Diplom.Core;
using DIPLOM.Diplom.PageObject;
using NUnit.Allure.Attributes;
using NUnit.Framework;

namespace DIPLOM.Diplom.Test
{
    internal class Registration_tests : BaseTests
    {
        [Test(Description = "Registration of random mail and filling in user data")]
        [AllureSeverity(SeverityLevel.normal)]
        [AllureTag("Smoke Create User")]
        [Description("Tests Allure")]
        [AllureOwner("Roman")]
        [AllureSuite("Registration user")]
        [AllureSubSuite("New user")]
        [AllureTms("TMS-16")]
        [AllureIssue("JIRA-15")]
        [AllureLink("https://github.com/Daivols6/SeleniumNunit")]
        
        public void Create()
        {
            new RegistrationPageWithBaseElement().NewUser();
        }
        
        [Test(Description = "Authorization of an already created account")]
        public void Registration()
        {
            new LoginPage()
            .OpenPage()
            .LoginAsStandartUser();
        }

        [Test(Description = "creating a user with a new mail")]
        public void CreateUser()
        {
            new LoginPageWithBaseElement()
                .CreateNewUser();
        }
    }
}
