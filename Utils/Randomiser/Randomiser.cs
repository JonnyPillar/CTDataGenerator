using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CTDataGenerator.Data;
using CTDataGenerator.Data.Models;

namespace CTDataGenerator.Utils.Randomiser
{
    public class Randomiser
    {
        CTDatabaseContainer ctDatabase = new CTDatabaseContainer();

        public Randomiser()
        {

        }

        public void GenerateUsers(int numberOfUsers)
        {
            ActivityLevel activityLevel = 0;
            PersonalityType personalityType = 0;
            Random random = new Random();
            RandomUser newUser = null;

            for (int i = 0; i < numberOfUsers; i++)
            {
                newUser = new RandomUser();

                ctDatabase.Users.Add(user);
            }
        }

        public void GenerateFood()
        {
            
        }
    }
}
