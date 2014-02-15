using System;
using CTDataGenerator.Data;

namespace CTDataGenerator.Utils.Randomiser
{
    internal class RandomUser
    {
        private User _user;

        public RandomUser()
        {
            _user = new User();
            var rand = new Random();
            var passwordHasher = new PasswordHasher("temppass123");

            _user.DateOfBirth = UserUtil.GenerateRandomAge();
            _user.Gender = Convert.ToBoolean(rand.Next(0, 1));
            _user.PasswordHash = passwordHasher.PasswordHash;
            _user.PasswordSalt = passwordHasher.PasswordSalt;
            _user.AdminInt = Convert.ToSByte(0);
            _user.CreationTimestamp = UserUtil.GenerateRandomJoinedDate();
        }

        public User NewUser
        {
            get { return _user; }
            set { _user = value; }
        }
    }
}