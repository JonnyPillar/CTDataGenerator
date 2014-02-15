using System;
using CTDataGenerator.Data;

namespace CTDataGenerator.Utils.Randomiser
{
    internal class RandomFoodLog
    {
        private FoodLog _foodLog;

        /// <summary>
        ///     Create a new Food Log
        /// </summary>
        /// <param name="userID">User ID</param>
        /// <param name="numberOfFoods">Number Of Foods In DB</param>
        public RandomFoodLog(int userID, int numberOfFoods)
        {
            var random = new Random();
            _foodLog = new FoodLog(random.Next(0, numberOfFoods), userID);
            _foodLog.Quantity = random.Next(0, 20);
        }

        private FoodLog NewFoodLog
        {
            get { return _foodLog; }
            set { _foodLog = value; }
        }
    }
}