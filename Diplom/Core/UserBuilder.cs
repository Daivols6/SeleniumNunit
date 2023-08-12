using Diplom.Diplom.PageObject;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPLOM.Diplom.Core
{
    public class UserBuilder
    {
        public static UserModel GetStandartUser()
        {
            return new UserModel
            {
                Name = TestContext.Parameters.Get("StandartUserName"),
                Password = TestContext.Parameters.Get("StandartPassword"),
            };
        }
        public static UserModel GetRandomUser()
        {
            return new UserModel
            {
                Name = Faker.Internet.Email(),
                Password = Faker.Phone.Number(),
            };
        }
        public static UserModel GetStandartUserWithoutName()
        {
            return new UserModel
            {
                Name = " ",
                Password = TestContext.Parameters.Get("StandartPassword"),
            };
        }
        public static UserModel GetDataUserForRegistration()
        {
            return new UserModel
            {
                FirstName = Faker.Name.First(),
                LastName = Faker.Name.Last(),
                Address = Faker.Address.StreetSuffix(),
                Zip = Faker.Address.ZipCode(),
                City = Faker.Address.City(),
                Homephone = Faker.Phone.Number(),
                Mobilephone = Faker.Phone.Number(),
            };
        }
    }
}

