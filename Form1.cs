using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using CTDataGenerator.Data;
using CTDataGenerator.Utils.CSVImport.FoodImport;

namespace CTDataGenerator
{
    public partial class Form1 : Form
    {
        public enum PersonType { Obese, Lazy, Average, Fit, Athlete };

        private const int numberOfDays = 7;

        public Form1()
        {
            InitializeComponent();
        }

        private void connectDBButton_Click(object sender, EventArgs e)
        {
            //FoodCsvImporter importer = new FoodCsvImporter();
            //importer.ProcessFoodDataFiles();

            //GenerateTimePerWeekChart();
            return;



            //CTEntities ctEntities = new CTEntities();
            //Random gen = new Random();
            //List<int> usersAgeRangeList = new List<int>();
            //User newUser = null;

            //int currentNumberOfUsers = ctEntities.Users.Count();

            //for (int i = 0; i < 101; i++)
            //{
            //    usersAgeRangeList.Add(0);
            //}

            //for (int i = 0; i < 999; i++)
            //{
            //    if (i + currentNumberOfUsers > 999) break;
            //    newUser = new User(CreateRandomBirthday(), gen.Next(0, 2), "temppass123"); //Set Random Birthday
            //    newUser.CreationTimestamp = CreateRandomJoinedDate(); //Set Random Joined Date
            //    newUser.ActivityLevel = gen.Next(0, 5);

            //    //Add Activites For Users
            //    newUser.ActivityLogs = CreateActivity(newUser, (PersonType) newUser.ActivityLevel);

            //    //Record Age
            //    usersAgeRangeList[DateTime.Now.Year - newUser.DateOfBirth.Year]++;
                
            //    //Record In DB
            //    ctEntities.Users.Add(newUser);
            //}

            //ageChart.Series.Clear();
            //ageChart.Series.Add("test3");

            //List<int> usersAgeRangeList = generateAgeChart();

            //for (int i = 0; i < usersAgeRangeList.Count; i++)
            //{
            //    ageChart.Series["test3"].Points.AddXY(i, usersAgeRangeList[i]);
            //}

            //ageChart.Series["test3"].ChartType = SeriesChartType.Line;
            //ageChart.Series["test3"].Color = Color.Red;

         
        }

        //public List<int> generateAgeChart()
        //{
        //    CTEntities ctEntities = new CTEntities();
        //    List<int> usersAgeRangeList = new List<int>();

        //    List<User> userList = ctEntities.Users.ToList();

        //    for (int i = 0; i < 101; i++)
        //    {
        //        usersAgeRangeList.Add(0);
        //    }
        //    for (int i = 0; i < userList.Count; i++)
        //    {
        //        usersAgeRangeList[DateTime.Now.Year - userList[i].DateOfBirth.Year]++;
        //    }

        //    return usersAgeRangeList;
        //}

        //public List<ActivityLog> CreateActivity(User user, PersonType personType)
        //{
        //    List<ActivityLog> activityList = new List<ActivityLog>();
        //    Random rand = new Random();
        //    int activityCount = 0;

        //    if (personType == PersonType.Obese)
        //    {
        //        //No Activities    
        //    }
        //    else if (personType == PersonType.Lazy)
        //    {
        //        //1 Low Intensity
        //        //6 Days off
        //        int numberOfActivies = 1;
        //        int activitySpacing = CalculateActivitySpacing(numberOfActivies);
        //        DateTime startTime = user.CreationTimestamp;
        //        double numberOfWeeks = (DateTime.Now - startTime).TotalDays / 7;
        //        for (int i = 0; i < numberOfWeeks; i++)
        //        {
        //            activityCount = 0;
        //            for (int j = 0; j < numberOfDays; j++)
        //            {
        //                if (activityCount == numberOfActivies) break;
        //                ActivityLog activityLog = new ActivityLog(rand.Next(1, 5), user.UserID, new TimeSpan(rand.Next(15, 60), rand.Next(0, 60), 0), rand.Next(2, 5), "Title", 0, 0, "", "", startTime);
        //                activityList.Add(activityLog);
        //                startTime = startTime.AddDays(activitySpacing + 7);
        //                activityCount++;
        //            }
        //        }
        //    }
        //    else if (personType == PersonType.Average)
        //    {
        //        //1 Medium Intensity
        //        //4 days off

        //        int numberOfActivies = 3;
        //        int activitySpacing = CalculateActivitySpacing(numberOfActivies);
        //        DateTime startTime = user.CreationTimestamp;
        //        double numberOfWeeks = (DateTime.Now - startTime).TotalDays / 7;
        //        for (int i = 0; i < numberOfWeeks; i++)
        //        {
        //            activityCount = 0;
        //            for (int j = 0; j < numberOfDays; j++)
        //            {
        //                if (activityCount == numberOfActivies) break;
        //                ActivityLog activityLog = new ActivityLog(rand.Next(1, 5), user.UserID, new TimeSpan(rand.Next(15, 60), rand.Next(0, 60), 0), rand.Next(2, 5), "Title", 0, 0, "", "", startTime);
        //                activityList.Add(activityLog);
        //                startTime = startTime.AddDays(activitySpacing + 7);
        //                activityCount++;
        //            }
        //        }
        //    }
        //    else if (personType == PersonType.Fit)
        //    {
        //        //1 Medium Intensity
        //        //2 days off
        //        int numberOfActivies = 5;
        //        int activitySpacing = CalculateActivitySpacing(numberOfActivies);
        //        DateTime startTime = user.CreationTimestamp;
        //        double numberOfWeeks = (DateTime.Now - startTime).TotalDays / 7;
        //        for (int i = 0; i < numberOfWeeks; i++)
        //        {
        //            activityCount = 0;
        //            for (int j = 0; j < numberOfDays; j++)
        //            {
        //                if (activityCount == numberOfActivies) break;
        //                ActivityLog activityLog = new ActivityLog(rand.Next(1, 5), user.UserID, new TimeSpan(rand.Next(15, 60), rand.Next(0, 60), 0), rand.Next(2, 5), "Title", 0, 0, "", "", startTime);
        //                activityList.Add(activityLog);
        //                startTime = startTime.AddDays(activitySpacing + 7);
        //                activityCount++;
        //            }
        //        }
        //    }
        //    else if (personType == PersonType.Athlete)
        //    {
        //        //1 Day, 2 Medium
        //        //1 Day off
        //        int numberOfActivies = 6;
        //        int activitySpacing = CalculateActivitySpacing(numberOfActivies);
        //        DateTime startTime = user.CreationTimestamp;
        //        double numberOfWeeks = (DateTime.Now - startTime).TotalDays / 7;
        //        for (int i = 0; i < numberOfWeeks; i++)
        //        {
        //            activityCount = 0;
        //            for (int j = 0; j < numberOfDays; j++)
        //            {
        //                if (activityCount == numberOfActivies) break;
        //                ActivityLog activityLog = new ActivityLog(rand.Next(1, 5), user.UserID, new TimeSpan(rand.Next(15, 60), rand.Next(0, 60), 0), rand.Next(2, 5), "Title", 0, 0, "", "", startTime);
        //                activityList.Add(activityLog);
        //                startTime = startTime.AddDays(activitySpacing + 7);
        //                activityCount++;
        //            }
        //        }
        //    }

        //    return activityList;
        //}

        ///// <summary>
        ///// Calculate The Spacing Between Activites Based On User
        ///// </summary>
        ///// <returns>Spacing Between Activites</returns>
        //private int CalculateActivitySpacing(int numberOfActivites)
        //{
        //    return (int)Math.Ceiling(7.0 / numberOfActivites);
        //}

        ///// <summary>
        ///// Create a random user age
        ///// </summary>
        ///// <returns>Users Birth Date</returns>
        //private DateTime CreateRandomBirthday()
        //{
        //    DateTime userDateOfBirth = new DateTime(1914, 1, 1);
        //    Random randomNoGenerator = new Random();
        //    int birthdayRange = ((DateTime.Today.AddYears(-18)) - userDateOfBirth).Days; //Set The Lowest Age We Have
        //    userDateOfBirth = userDateOfBirth.AddDays(randomNoGenerator.Next(birthdayRange)); //Create Number Between Low and 0
        //    return userDateOfBirth;
        //}

        //private DateTime CreateRandomJoinedDate()
        //{
        //    DateTime userJoinedDate = new DateTime(2013, 1, 1);
        //    Random randomNoGenerator = new Random();

        //    int creationRange = (DateTime.Today - userJoinedDate).Days;
        //    userJoinedDate = userJoinedDate.AddDays(randomNoGenerator.Next(creationRange));
        //    return userJoinedDate;
        //}


        //private void GenerateTimePerWeekChart()
        //{
        //    timerPerWeekChart = new Chart();
        //    timerPerWeekChart.Series.Clear();

        //    var fitUserSeries = new Series();
        //    fitUserSeries.Name = "Fit Users";
        //    fitUserSeries.ChartType = SeriesChartType.Line;

        //    timerPerWeekChart.Series.Add(fitUserSeries);
            
        //    CTEntities db = new CTEntities();


        //    for (int i = 0; i < 5; i++)
        //    {
        //        var temp = db.activity_Count_Per_Week_For_User_Type2(i);
        //        //var temp = db.Temps.SqlQuery("pillarj.activity_Count_Per_Week_For_User_Type(?), i").ToList();

        //        //var temp = db.Database.ExecuteSqlCommand<int>( "SELECT Floor(TIMESTAMPDIFF(day, activity_log_start_date, NOW()) / 7) as WeekNumber, activity_log_duration as Duration FROM tbl_user INNER JOIN tbl_activity_log ON tbl_user.user_id = tbl_activity_log.activity_log_user_id  WHERE user_activity_level_type=? GROUP BY WeekNumber ORDER BY activity_log_start_date", i);

        //    }




        //}



        //private void getData()
        //{
        //    int count = 0;

        //    CTEntities db = new CTEntities();

        //    Dictionary<int, List<TimeSpan>> weeklyTimeSpanDictionary = new Dictionary<int, List<TimeSpan>>();
        //    int beginningDay = (DateTime.Now - new DateTime(2013, 1, 1)).Days;
        //    IEnumerable<User> query = db.Users.Where(ru => ru.ActivityLevel == 4).ToList();
        //    foreach (User user in query)
        //    {
        //        IEnumerable<ActivityLog> activityLog = user.ActivityLogs.OrderBy(e => e.StartDate).ToList();
        //        foreach (var log in activityLog)
        //        {
        //            int startDays = (DateTime.Now - log.StartDate).Days;
        //            int weekNumber = (startDays - beginningDay)/7;

        //            if(weeklyTimeSpanDictionary.ContainsKey(weekNumber)) weeklyTimeSpanDictionary[weekNumber].Add(log.Duration);
        //            else weeklyTimeSpanDictionary.Add(weekNumber, new List<TimeSpan>() { log.Duration });
        //            count++;
        //        }
        //    }
        //    int numberOfWeeks = weeklyTimeSpanDictionary.Count;
        //    db.Dispose();
        //}

        //public IQueryable<ActivityLog> getCompaniesByStatus(int status)
        //{
        //    return CTEntities.tbl_activity_log
        //                   .Where(c => c.bedrijf_status == status)
        //                   .OrderBy(c => c.bedrijf_naam);
        //}

    }
}
