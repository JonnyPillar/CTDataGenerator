using System;
using CTDataGenerator.Data;

namespace CTDataGenerator.Utils.Randomiser
{
    public class RandomActivityLog
    {
        private ActivityLog _activityLog;

        /// <summary>
        ///     Create A Random Activity Log
        /// </summary>
        /// <param name="numberOfActivities">Max number of Activites</param>
        /// <param name="user">User</param>
        public RandomActivityLog(int numberOfActivities, User user)
        {
            var random = new Random();
            _activityLog = new ActivityLog(random.Next(numberOfActivities), user.UserID);
            _activityLog.StartDate = RandomDateUtil.CreateRandomActivityDate(user.CreationTimestamp);
            _activityLog.Duration = new TimeSpan(random.Next(4), random.Next(60), random.Next(60));
            _activityLog.Distance = random.Next(40);
            _activityLog.Title = "New Random Activity";
            _activityLog.Accent = random.Next(500);
            _activityLog.HeartRate = random.Next(100, 200);
            _activityLog.Notes = string.Empty;
            _activityLog.FileURL = string.Empty;
        }

        public ActivityLog NewActivityLog
        {
            get { return _activityLog; }
            set { _activityLog = value; }
        }
    }
}