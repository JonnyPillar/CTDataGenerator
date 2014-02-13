using System;
using System.Collections.Generic;
using CTDataGenerator.Utils;

namespace CTDataGenerator.Data
{
    public partial class User
    {
        /// <summary>
        ///     User Constructor
        /// </summary>
        /// <param name="dateOfBirth">Date Of Birth</param>
        /// <param name="gender">Gender</param>
        /// <param name="password">Password String</param>
        public User(DateTime dateOfBirth, int gender, string password)
        {
            DateOfBirth = dateOfBirth;
            Gender = Convert.ToBoolean(gender);
            var passwordHasher = new PasswordHasher(password);
            PasswordHash = passwordHasher.PasswordHash;
            PasswordSalt = passwordHasher.PasswordSalt;
            AdminInt = 0;
            CreationTimestamp = DateTime.Now;

            ActivityLogs = new HashSet<ActivityLog>();
            FoodLogs = new HashSet<FoodLog>();
            MetricLogs = new HashSet<MetricLog>();
        }

        /// <summary>
        ///     User Constructor
        /// </summary>
        /// <param name="dateOfBirth">Date Of Birth</param>
        /// <param name="gender">Gender</param>
        /// <param name="password">Password String</param>
        public User(DateTime dateOfBirth, Gender gender, string password)
        {
            DateOfBirth = dateOfBirth;
            Gender = Convert.ToBoolean(gender);
            var passwordHasher = new PasswordHasher(password);
            PasswordHash = passwordHasher.PasswordHash;
            PasswordSalt = passwordHasher.PasswordSalt;
            AdminInt = 0;
            CreationTimestamp = DateTime.Now;

            ActivityLogs = new HashSet<ActivityLog>();
            FoodLogs = new HashSet<FoodLog>();
            MetricLogs = new HashSet<MetricLog>();
        }

        /// <summary>
        ///     User Constructor
        /// </summary>
        /// <param name="userID">User ID</param>
        /// <param name="dateOfBirth">Date Of Birth</param>
        /// <param name="gender">Gender</param>
        /// <param name="password">Password String</param>
        public User(int userID, DateTime dateOfBirth, int gender, string password)
        {
            UserID = userID;
            DateOfBirth = dateOfBirth;
            Gender = Convert.ToBoolean(gender);
            var passwordHasher = new PasswordHasher(password);
            PasswordHash = passwordHasher.PasswordHash;
            PasswordSalt = passwordHasher.PasswordSalt;
            AdminInt = 0;
            CreationTimestamp = DateTime.Now;

            ActivityLogs = new HashSet<ActivityLog>();
            FoodLogs = new HashSet<FoodLog>();
            MetricLogs = new HashSet<MetricLog>();
        }

        /// <summary>
        ///     User Constructor
        /// </summary>
        /// <param name="userID">User ID</param>
        /// <param name="dateOfBirth">Date Of Birth</param>
        /// <param name="gender">Gender</param>
        /// <param name="password">Password String</param>
        /// <param name="admin">Admin Account</param>
        public User(int userID, DateTime dateOfBirth, int gender, string password, bool admin)
        {
            UserID = userID;
            DateOfBirth = dateOfBirth;
            Gender = Convert.ToBoolean(gender);
            var passwordHasher = new PasswordHasher(password);
            PasswordHash = passwordHasher.PasswordHash;
            PasswordSalt = passwordHasher.PasswordSalt;
            AdminInt = Convert.ToSByte(admin);
            CreationTimestamp = DateTime.Now;

            ActivityLogs = new HashSet<ActivityLog>();
            FoodLogs = new HashSet<FoodLog>();
            MetricLogs = new HashSet<MetricLog>();
        }

        /// <summary>
        ///     Random User
        /// </summary>
        /// <param name="activityLevel">Activity Level</param>
        /// <param name="personalityType">Personality Type</param>
        public User(ActivityLevel activityLevel, int personalityType)
        {
            var rand = new Random();
            DateOfBirth = UserUtil.GenerateRandomAge();
            Gender = Convert.ToBoolean(rand.Next(0, 1));
            var passwordHasher = new PasswordHasher("temppass123");
            PasswordHash = passwordHasher.PasswordHash;
            PasswordSalt = passwordHasher.PasswordSalt;
            AdminInt = Convert.ToSByte(0);
            CreationTimestamp = UserUtil.GenerateRandomJoinedDate();

            ActivityLevel = (int) activityLevel;
            Personality = personalityType;

            ActivityLogs = new HashSet<ActivityLog>();
            FoodLogs = new HashSet<FoodLog>();
            MetricLogs = new HashSet<MetricLog>();
        }

        public int AdminInt
        {
            get { return Convert.ToInt16(Admin); }
            set { Admin = Convert.ToBoolean(value); }
        }
    }
}