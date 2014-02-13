using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CTDataGenerator.Data;

namespace CTDataGenerator.Utils
{
    public class UserUtil
    {
        public static DateTime GenerateRandomAge()
        {
            DateTime maxUserAge = DateTime.Now.AddYears(-80); // Max 80 Years Old
            DateTime minUserAge = DateTime.Now.AddYears(-18); //Min 18 years old
            Random randomNoGenerator = new Random();
            int birthdayRange = (minUserAge - maxUserAge).Days; //Set The Lowest Age We Have
            maxUserAge = maxUserAge.AddDays(randomNoGenerator.Next(birthdayRange)); //Create Number Between Low and 0
            return maxUserAge;
        }

        public static DateTime GenerateRandomJoinedDate()
        {
            DateTime userJoinedDate = new DateTime(2012, 1, 1); //Eariler Start Date
            Random randomNoGenerator = new Random();

            int creationRange = (DateTime.Today - userJoinedDate).Days;
            userJoinedDate = userJoinedDate.AddDays(randomNoGenerator.Next(creationRange));
            return userJoinedDate;
        }

        public void GenerateRandomHeight(Gender gender)
        {
            if (gender.Equals(Gender.Male))
            {
                //M : 160 - 175 - 201

                Random r = new Random();
                r.Next(160, 200);
            }
            else if (gender.Equals(Gender.Female))
            {
                //W : 137 - 163 - 191
            }
        }


        public void generateUser()
        {
            //Generate Age 18 - 80
            //Generate Gender M/F
            //Generate Height 4.6 - 6.7 Averaage 5ft 9 M 5ft 4 F

            //M : 160 - 175 - 201

            //W : 137 - 163 - 191



            //Generate Weight 6 - 20
            //Generate Activity Level 1 - 5

            /*
             * Calc BMR
             * 
             *      M
             *          66 + (6.23 x weight in pounds) + (12.7 x height in inches)
             *      F
             *          65 + ( 4.35 x weight in pounds) + (4.7 x height in inches)
             * 
             *  Activity Level
             * 
             * 1
             *      BMR x 1.2
             *      Little / No Excersise
             *      25%+     
             * 
             * 2
             * 
             *      BMR x 1.375
             *      Light Excercise
             *      1 - 3 Days a week
             *      18 - 24%
             * 3
             * 
             *      BMR x 1.55
             *      Moderate Excercise
             *      3 - 5 Days a week
             *      15-22%%     
             * 
             * 4
             * 
             *      BMR x 1.725
             *      Hard Excersise
             *      6 - 7 Days a week
             *      
             *      14 - 17% Body Fat
             * 
             * 5
             * 
             *      BMR x 1.9
             *      Very Hard Excersise
             *      6-7 Days a week
             *      2x a Day
             *      
             *      Low Skin Fat
             *      6 - 13 %
             * 
             * 
             */
        }

    }
}
