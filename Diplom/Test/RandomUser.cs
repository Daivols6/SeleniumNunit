using Diplom.Diplom.PageObject;
using Diplom.SeleniumTests.Diplom;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom.Diplom.Test
{
    internal class RandomUser : BaseTests
    {
        [Test]
        public void RandomUserTest()
        {
            new LoginPage()
            .OpenPage()
            .RandomUser();
            Thread.Sleep(1000);
        }
    }
}
