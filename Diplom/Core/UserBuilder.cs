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
                Email = Faker.Internet.Email(),
                Password = Faker.Phone.Number(),
            };
        }
        public static UserModel GetUser()
        {
            return new UserModel
            {
                Email = Faker.Internet.Email(),
                Password = Faker.Phone.Number(),
            };
        }
        public static UserModel GetNewUser()
        {
            return new UserModel
            {
                FirstName = Faker.Name.First(),
                LastName = Faker.Name.Last(),
                Password = Faker.Address.UkPostCode(),
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
                Zip = Faker.RandomNumber.Next(10000,99999).ToString(),
                City = Faker.Address.City(),
                Homephone = Faker.Phone.Number(),
                Mobilephone = Faker.Phone.Number(),
                AddressTitle = Faker.Address.StreetAddress(),
            };
        }
    }
}

