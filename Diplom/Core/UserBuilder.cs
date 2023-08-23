using NUnit.Framework;

namespace DIPLOM.Diplom.Core
{
    public class UserBuilder
    {
     //получение ранее созданного существующего пользователя, логин и пароль.
        public static UserModel GetStandartUser()
        {
            return new UserModel
            {
                Name = TestContext.Parameters.Get("StandartUserName"),
                Password = TestContext.Parameters.Get("StandartPassword"),
            };
        }
        //получение случайного пользователя, логин и пароль.
        public static UserModel GetRandomUser()
        {
            return new UserModel
            {
                Email = Faker.Internet.Email(),
                Password = Faker.Phone.Number(),
            };
        }
        //получение данных для регистрации Имя Фамилия Пароль
        public static UserModel GetNewUser()
        {
            return new UserModel
            {
                FirstName = Faker.Name.First(),
                LastName = Faker.Name.Last(),
                Password = Faker.Address.UkPostCode(),
            };
        }
        //получение пароля для существующего пользователя, и пустого имени пользователя
        public static UserModel GetStandartUserWithoutName()
        {
            return new UserModel
            {
                Name = " ",
                Password = TestContext.Parameters.Get("StandartPassword"),
            };
        }
        //получение данных для регистрации пользователя  Имя, Фамилия, Адрес, Почта, Город, Домашний телефон, Мобильный телефон, Полный адрес.
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

