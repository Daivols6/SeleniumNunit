using Diplom.Diplom.PageObject;
using DIPLOM.Diplom.Core;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPLOM.Diplom.Test
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
