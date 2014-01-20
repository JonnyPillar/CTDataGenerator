using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

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

            int currentNumberOfUsers = ctEntities.tbl_user.Count();

            List<int> usersAgeRangeList = new List<int>();
            tbl_user newUser = new tbl_user();
            DateTime userDateOfBirth = new DateTime(1914, 1, 1);
            DateTime userJoinedDate = new DateTime(2013, 1, 1);


            for (int i = 0; i < 101; i++)
            {
                usersAgeRangeList.Add(0);
            }

            Random gen = new Random(); 
            Console.WriteLine("Start");

            for (int i = 0; i < 400; i++)
            {
                if (i + currentNumberOfUsers > 999) break;
                newUser = new tbl_user();
                userDateOfBirth = new DateTime(1914, 1, 1);
                userJoinedDate = new DateTime(2013, 1, 1);

                int birthdayRange = ((DateTime.Today.AddYears(-18)) - userDateOfBirth).Days;
                userDateOfBirth = userDateOfBirth.AddDays(gen.Next(birthdayRange));
                
                int age = DateTime.Now.Year - userDateOfBirth.Year;
                usersAgeRangeList[age]++;

                newUser.user_dob = userDateOfBirth;
                newUser.user_gender = Convert.ToSByte(gen.Next(0, 2));
                newUser.user_password_hash = "";
                newUser.user_password_salt = "";

                int creationRange = (DateTime.Today - userJoinedDate).Days;
                userJoinedDate = userJoinedDate.AddDays(gen.Next(creationRange));

                newUser.user_creation_timestamp = userJoinedDate;
                newUser.user_admin = 0;
                newUser.user_activity_level_type = gen.Next(1, 5);

                newUser.tbl_activity_log = CreateActivity(newUser, (PersonType) newUser.user_activity_level_type);

                ctEntities.tbl_user.Add(newUser);
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

        public List<tbl_activity_log> CreateActivity(tbl_user user, PersonType personType)
        {
            //
            List<tbl_activity_log> activityList = new List<tbl_activity_log>();
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
                DateTime startTime = user.user_creation_timestamp;

                double numberOfWeeks = (DateTime.Now - startTime).TotalDays / 7;

                int activityCount = 0;

                for (int i = 0; i < numberOfWeeks; i++)
                {
                    if (activityCount == numberOfActivies) break;

                    tbl_activity_log activityLog = new tbl_activity_log();

                    activityLog.activity_log_id = Guid.NewGuid().ToString();
                    activityLog.activity_log_start_date = startTime;
                    activityLog.activity_log_activity_id = "1"; //TODO use differnt activities
                    activityLog.activity_log_user_id = user.user_id;
                    activityLog.activity_log_duration = new TimeSpan(rand.Next(15, 60), rand.Next(0, 60), 0);
                    activityLog.activity_log_distance = rand.Next(2, 5);
                    activityLog.activity_log_title = "Title";
                    activityLog.activity_log_accent = 0;
                    activityLog.activity_log_heart_rate = 0;
                    activityLog.activity_log_notes = "";
                    activityLog.activity_log_file_url = "";

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
                int activitySpacing = (int) Math.Ceiling(7.0 / numberOfActivies);
                DateTime startTime = user.user_creation_timestamp;

                double numberOfWeeks = (DateTime.Now - startTime).TotalDays / 7;

                int activityCount = 0;

                for (int i = 0; i < numberOfWeeks; i++)
                {
                    if (activityCount == numberOfActivies) break;

                    tbl_activity_log activityLog = new tbl_activity_log();

                    activityLog.activity_log_id = Guid.NewGuid().ToString();
                    activityLog.activity_log_start_date = startTime;
                    activityLog.activity_log_activity_id = "1"; //TODO use differnt activities
                    activityLog.activity_log_user_id = user.user_id;
                    activityLog.activity_log_duration = new TimeSpan(rand.Next(15, 60), rand.Next(0, 60), 0);
                    activityLog.activity_log_distance = rand.Next(2, 5);
                    activityLog.activity_log_title = "Title";
                    activityLog.activity_log_accent = 0;
                    activityLog.activity_log_heart_rate = 0;
                    activityLog.activity_log_notes = "";
                    activityLog.activity_log_file_url = "";
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
                DateTime startTime = user.user_creation_timestamp;

                double numberOfWeeks = (DateTime.Now - startTime).TotalDays / 7;

                int activityCount = 0;

                for (int i = 0; i < numberOfWeeks; i++)
                {
                    if (activityCount == numberOfActivies) break;

                    tbl_activity_log activityLog = new tbl_activity_log();

                    activityLog.activity_log_id = Guid.NewGuid().ToString();
                    activityLog.activity_log_start_date = startTime;
                    activityLog.activity_log_activity_id = "1"; //TODO use differnt activities
                    activityLog.activity_log_user_id = user.user_id;
                    activityLog.activity_log_duration = new TimeSpan(rand.Next(15, 60), rand.Next(0, 60), 0);
                    activityLog.activity_log_distance = rand.Next(2, 5);
                    activityLog.activity_log_title = "Title";
                    activityLog.activity_log_accent = 0;
                    activityLog.activity_log_heart_rate = 0;
                    activityLog.activity_log_notes = "";
                    activityLog.activity_log_file_url = "";
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
                DateTime startTime = user.user_creation_timestamp;

                double numberOfWeeks = (DateTime.Now - startTime).TotalDays / 7;

                int activityCount = 0;

                for (int i = 0; i < numberOfWeeks; i++)
                {
                    if (activityCount == numberOfActivies) break;

                    tbl_activity_log activityLog = new tbl_activity_log();

                    activityLog.activity_log_id = Guid.NewGuid().ToString();
                    activityLog.activity_log_start_date = startTime;
                    activityLog.activity_log_activity_id = "1"; //TODO use differnt activities
                    activityLog.activity_log_user_id = user.user_id;
                    activityLog.activity_log_duration = new TimeSpan(rand.Next(15, 60), rand.Next(0, 60), 0);
                    activityLog.activity_log_distance = rand.Next(2, 5);
                    activityLog.activity_log_title = "Title";
                    activityLog.activity_log_accent = 0;
                    activityLog.activity_log_heart_rate = 0;
                    activityLog.activity_log_notes = "";
                    activityLog.activity_log_file_url = "";
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
