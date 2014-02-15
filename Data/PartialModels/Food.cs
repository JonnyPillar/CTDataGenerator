using System;

namespace CTDataGenerator.Data
{
    public partial class Food
    {
        private const char StringDelimeter = '^';

        /// <summary>
        ///     Food Constructor
        /// </summary>
        /// <param name="csvString">
        ///     Line From Data File: Example: ~01001~^~0100~^~Butter, salted~^~BUTTER,WITH
        ///     SALT~^~~^~~^~Y~^~~^0^~~^6.38^4.27^8.79^3.87
        ///     Ignore [4] and > [5]
        /// </param>
        public Food(string csvString)
        {
            csvString = csvString.Replace("~", "");
            string[] csvStringSplit = csvString.Split(StringDelimeter);
            SourceID = Convert.ToInt32(csvStringSplit[0]);
            GroupID = Convert.ToInt32(csvStringSplit[1]); //Unsure On This One
            Name = csvStringSplit[2];
            Description = csvStringSplit[3];
            ManufacturerName = csvStringSplit[5];
        }
    }
}