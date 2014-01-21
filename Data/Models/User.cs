using CTDataGenerator.Utils;
using System;

namespace CTDataGenerator.Data
{
    public partial class User
    {
        /// <summary>
        /// User Constructor
        /// </summary>
        /// <param name="dateOfBirth">Date Of Birth</param>
        /// <param name="gender">Gender</param>
        /// <param name="password">Password String</param>
        public User(DateTime dateOfBirth, int gender, string password)
        {
            this.DateOfBirth = dateOfBirth;
            this.Gender = Convert.ToSByte(gender);
            PasswordHasher passwordHasher = new PasswordHasher(password);
            this.PasswordHash = passwordHasher.PasswordHash;
            this.PasswordSalt = passwordHasher.PasswordSalt;
            this.AdminInt = 0;
            this.CreationTimestamp = DateTime.Now;
        }

        /// <summary>
        /// User Constructor
        /// </summary>
        /// <param name="userID">User ID</param>
        /// <param name="dateOfBirth">Date Of Birth</param>
        /// <param name="gender">Gender</param>
        /// <param name="password">Password String</param>
        public User(int userID, DateTime dateOfBirth, int gender, string password)
        {
            this.UserID = userID;
            this.DateOfBirth = dateOfBirth;
            this.Gender = Convert.ToSByte(gender);
            PasswordHasher passwordHasher = new PasswordHasher(password);
            this.PasswordHash = passwordHasher.PasswordHash;
            this.PasswordSalt = passwordHasher.PasswordSalt;
            this.AdminInt = 0;
            this.CreationTimestamp = DateTime.Now;
        }

        /// <summary>
        /// User Constructor
        /// </summary>
        /// <param name="userID">User ID</param>
        /// <param name="dateOfBirth">Date Of Birth</param>
        /// <param name="gender">Gender</param>
        /// <param name="password">Password String</param>
        /// <param name="admin">Admin Account</param>
        public User(int userID, DateTime dateOfBirth, int gender, string password, bool admin)
        {
            this.UserID = userID;
            this.DateOfBirth = dateOfBirth;
            this.Gender = Convert.ToSByte(gender);
            PasswordHasher passwordHasher = new PasswordHasher(password);
            this.PasswordHash = passwordHasher.PasswordHash;
            this.PasswordSalt = passwordHasher.PasswordSalt;
            this.AdminInt = Convert.ToSByte(admin);
            this.CreationTimestamp = DateTime.Now;
        }
    }
}
