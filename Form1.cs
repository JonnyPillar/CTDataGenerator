using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using CTDataGenerator.Data;

namespace CTDataGenerator
{
    public partial class Form1 : Form
    {
        public enum PersonType { Obese, Lazy, Average, Fit, Athlete };

        public Form1()
        {
            InitializeComponent();
        }

        private void connectDBButton_Click(object sender, EventArgs e)
        {
            CTEntities ctEntities = new CTEntities();

            int currentNumberOfUsers = ctEntities.Users.Count();

            List<int> usersAgeRangeList = new List<int>();
            User newUser = new User();
            DateTime userDateOfBirth = new DateTime(1914, 1, 1);
            DateTime userJoinedDate = new DateTime(2013, 1, 1);


            for (int i = 0; i < 101; i++)
            {
                usersAgeRangeList.Add(0);
            }

            Random gen = new Random();
            Console.WriteLine("Start");

            for (int i = 0; i < 999; i++)
            {
                if (i + currentNumberOfUsers > 999) break;
                newUser = new User();
                userDateOfBirth = new DateTime(1914, 1, 1);
                userJoinedDate = new DateTime(2013, 1, 1);

                int birthdayRange = ((DateTime.Today.AddYears(-18)) - userDateOfBirth).Days;
                userDateOfBirth = userDateOfBirth.AddDays(gen.Next(birthdayRange));

                int age = DateTime.Now.Year - userDateOfBirth.Year;
                usersAgeRangeList[age]++;

                newUser.DateOfBirth = userDateOfBirth;
                newUser.Gender = Convert.ToSByte(gen.Next(0, 2));
                newUser.PasswordHash = "";
                newUser.PasswordSalt = "";

                int creationRange = (DateTime.Today - userJoinedDate).Days;
                userJoinedDate = userJoinedDate.AddDays(gen.Next(creationRange));

                newUser.CreationTimestamp = userJoinedDate;
                newUser.AdminInt = 0;
                newUser.ActivityLevel = gen.Next(1, 5);

                newUser.tbl_activity_log = CreateActivity(newUser, (PersonType)newUser.ActivityLevel);

                ctEntities.Users.Add(newUser);
                Console.WriteLine(i);
                countLabel.Text = i.ToString();
            }

            ageChart.Series.Clear();
            ageChart.Series.Add("test3");

            for (int i = 0; i < usersAgeRangeList.Count; i++)
            {
                ageChart.Series["test3"].Points.AddXY(i, usersAgeRangeList[i]);
            }

            ageChart.Series["test3"].ChartType = SeriesChartType.FastLine;
            ageChart.Series["test3"].Color = Color.Red;

            Console.WriteLine("Begin Save");
            ctEntities.SaveChanges();
            Console.WriteLine("End");
        }

        public List<ActivityLog> CreateActivity(User user, PersonType personType)
        {
            //
            List<ActivityLog> activityList = new List<ActivityLog>();
            Random rand = new Random();

            if (personType == PersonType.Obese)
            {
                //No Activities    
            }
            else if (personType == PersonType.Lazy)
            {
                //1 Low Intensity
                //6 Days off
                int numberOfActivies = 1;
                int activitySpacing = (int)Math.Ceiling(7.0 / numberOfActivies);
                DateTime startTime = user.CreationTimestamp;

                double numberOfWeeks = (DateTime.Now - startTime).TotalDays / 7;

                int activityCount = 0;

                for (int i = 0; i < numberOfWeeks; i++)
                {
                    if (activityCount == numberOfActivies) break;

                    ActivityLog activityLog = new ActivityLog();

                    activityLog.LogID = Guid.NewGuid().ToString();
                    activityLog.StartDate = startTime;
                    activityLog.ActivityID = "1"; //TODO use differnt activities
                    activityLog.UserID = user.UserID;
                    activityLog.Duration = new TimeSpan(rand.Next(15, 60), rand.Next(0, 60), 0);
                    activityLog.Distance = rand.Next(2, 5);
                    activityLog.Title = "Title";
                    activityLog.Accent = 0;
                    activityLog.HeartRate = 0;
                    activityLog.Notes = "";
                    activityLog.FileURL = "";

                    activityList.Add(activityLog);

                    startTime = startTime.AddDays(activitySpacing);

                    startTime = startTime.AddDays(7);
                    activityCount++;
                }
            }
            else if (personType == PersonType.Average)
            {
                //1 Medium Intensity
                //4 days off

                int numberOfActivies = 3;
                int activitySpacing = (int)Math.Ceiling(7.0 / numberOfActivies);
                DateTime startTime = user.CreationTimestamp;

                double numberOfWeeks = (DateTime.Now - startTime).TotalDays / 7;

                int activityCount = 0;

                for (int i = 0; i < numberOfWeeks; i++)
                {
                    if (activityCount == numberOfActivies) break;

                    ActivityLog activityLog = new ActivityLog();

                    activityLog.LogID = Guid.NewGuid().ToString();
                    activityLog.StartDate = startTime;
                    activityLog.ActivityID = "1"; //TODO use differnt activities
                    activityLog.UserID = user.UserID;
                    activityLog.Duration = new TimeSpan(rand.Next(15, 60), rand.Next(0, 60), 0);
                    activityLog.Distance = rand.Next(2, 5);
                    activityLog.Title = "Title";
                    activityLog.Accent = 0;
                    activityLog.HeartRate = 0;
                    activityLog.Notes = "";
                    activityLog.FileURL = "";
                    activityList.Add(activityLog);

                    startTime = startTime.AddDays(activitySpacing);

                    startTime = startTime.AddDays(7);
                    activityCount++;
                }

            }
            else if (personType == PersonType.Fit)
            {
                //1 Medium Intensity
                //2 days off
                int numberOfActivies = 5;
                int activitySpacing = (int)Math.Ceiling(7.0 / numberOfActivies);
                DateTime startTime = user.CreationTimestamp;

                double numberOfWeeks = (DateTime.Now - startTime).TotalDays / 7;

                int activityCount = 0;

                for (int i = 0; i < numberOfWeeks; i++)
                {
                    if (activityCount == numberOfActivies) break;

                    ActivityLog activityLog = new ActivityLog();

                    activityLog.LogID = Guid.NewGuid().ToString();
                    activityLog.StartDate = startTime;
                    activityLog.ActivityID = "1"; //TODO use differnt activities
                    activityLog.UserID = user.UserID;
                    activityLog.Duration = new TimeSpan(rand.Next(15, 60), rand.Next(0, 60), 0);
                    activityLog.Distance = rand.Next(2, 5);
                    activityLog.Title = "Title";
                    activityLog.Accent = 0;
                    activityLog.HeartRate = 0;
                    activityLog.Notes = "";
                    activityLog.FileURL = "";
                    activityList.Add(activityLog);

                    startTime = startTime.AddDays(activitySpacing);

                    startTime = startTime.AddDays(7);
                    activityCount++;
                }
            }
            else if (personType == PersonType.Athlete)
            {
                //1 Day, 2 Medium
                //1 Day off
                int numberOfActivies = 6;
                int activitySpacing = (int)Math.Ceiling(7.0 / numberOfActivies);
                DateTime startTime = user.CreationTimestamp;

                double numberOfWeeks = (DateTime.Now - startTime).TotalDays / 7;

                int activityCount = 0;

                for (int i = 0; i < numberOfWeeks; i++)
                {
                    if (activityCount == numberOfActivies) break;

                    ActivityLog activityLog = new ActivityLog();

                    activityLog.LogID = Guid.NewGuid().ToString();
                    activityLog.StartDate = startTime;
                    activityLog.ActivityID = "1"; //TODO use differnt activities
                    activityLog.UserID = user.UserID;
                    activityLog.Duration = new TimeSpan(rand.Next(15, 60), rand.Next(0, 60), 0);
                    activityLog.Distance = rand.Next(2, 5);
                    activityLog.Title = "Title";
                    activityLog.Accent = 0;
                    activityLog.HeartRate = 0;
                    activityLog.Notes = "";
                    activityLog.FileURL = "";
                    activityList.Add(activityLog);

                    startTime = startTime.AddDays(activitySpacing);

                    startTime = startTime.AddDays(7);
                    activityCount++;
                }
            }

            return activityList;
        }
    }
}
