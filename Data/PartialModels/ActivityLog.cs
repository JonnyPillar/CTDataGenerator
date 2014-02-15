using System;

namespace CTDataGenerator.Data
{
    public partial class ActivityLog
    {
        public ActivityLog()
        {
        }

        public ActivityLog(int activityId, int userId, TimeSpan duration, decimal distance, string title, decimal accent,
            int heartRate, string notes, string fileUrl, DateTime startDate)
        {
            ActivityID = activityId;
            UserID = userId;
            Duration = duration;
            Distance = distance;
            Title = title;
            Accent = accent;
            HeartRate = heartRate;
            Notes = notes;
            FileURL = fileUrl;
            StartDate = startDate;
        }
    }
}