using System;

namespace CTDataGenerator.Data
{
    public partial class FoodGroup
    {
        private const char StringDelimeter = '^';

        /// <summary>
        ///     Food Group Constructor
        /// </summary>
        /// <param name="csvString"> Line From Data File: Example: ~0100~^~Dairy and Egg Products~ </param>
        public FoodGroup(string csvString)
        {
            csvString = csvString.Replace("~", "");
            string[] csvStringSplit = csvString.Split(StringDelimeter);
            SourceID = Convert.ToInt32(csvStringSplit[0]);
            Name = csvStringSplit[1];
        }
    }
}