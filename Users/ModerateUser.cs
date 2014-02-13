using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CTDataGenerator.Data;

namespace CTDataGenerator.Users
{
    class ModerateUser : IUser
    {
        private User userObject;



        private DateTime userDOB;
        private decimal userHeight;
        private decimal userWeight;
        private int userActivityLevel;
        private int userPersonality;

        private decimal userBMR;
        

        public ModerateUser()
        {
            Random r = new Random();

            //Create Random User
            this.userObject = new User((ActivityLevel) r.Next(0 - 4), r.Next(0, 9));

            

        }

        private DateTime GenerateRandomAge()
        {
            TimeSpan ts = DateTime.Parse("1/1/1996") - DateTime.Parse("1/1/1940");
            Random r = new Random();
            int randomDays = r.Next(ts.Days + 1);
            return DateTime.Parse("1/1/1940").AddDays(randomDays);
        }
    }
}
