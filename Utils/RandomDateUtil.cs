using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTDataGenerator.Utils
{
    public class RandomDateUtil
    {
        /// <summary>
        /// Create a random user age
        /// </summary>
        /// <returns>Users Birth Date</returns>
        public static DateTime CreateRandomActivityDate(DateTime userStartDate)
        {
            Random randomNoGenerator = new Random();
            int birthdayRange = ((DateTime.Today) - userStartDate).Days; //Set The Lowest Age We Have
            userStartDate = userStartDate.AddDays(randomNoGenerator.Next(birthdayRange)); //Create Number Between Low and 0
            return userStartDate;
        }
    }
}
