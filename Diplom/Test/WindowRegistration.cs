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
    internal class WindowRegistration : BaseTests
    {
        [Test]
        public void Create()
        {
            new RegistrationPageWithBaseElement().NewUser();
        }
    }
}
