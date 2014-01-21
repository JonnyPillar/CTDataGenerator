using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTDataGenerator.Data
{
    public partial class ActivityLog
    {
        public ActivityLog()
        {
        }

        public ActivityLog(string activityId, int userId, TimeSpan duration, decimal distance, string title, decimal accent, int heartRate, string notes, string fileUrl, DateTime startDate)
        {
            this.LogID = Guid.NewGuid().ToString();
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
