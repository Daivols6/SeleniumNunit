using Allure.Commons;
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
    internal class WindowRegistration : BaseTests
    {
        [Test(Description = "Login new user")]
        [AllureSeverity(SeverityLevel.normal)]
        [AllureTag("Smoke Create User")]
        [Description("More detailed Description")]
        [AllureOwner("Roman")]
        [AllureSuite("Registration user")]
        [AllureSubSuite("New user")]
        [AllureTms("TMS-16")]
        [AllureIssue("JIRA-15")]
        [AllureLink("https://google.com")]

        public void Create()
        {
            new RegistrationPageWithBaseElement().NewUser();
        }
    }
}
