using System;

namespace CTDataGenerator.Data
{
    public partial class FoodNutrients
    {
        private const char StringDelimeter = '^';

        public FoodNutrients()
        {
            
        }

        /// <summary>
        ///     Food Nutrient Log
        /// </summary>
        /// <param name="csvString">Line From Data File: Example: ~01001~^~203~^0.85^16^0.074^~1~^~~^~~^~~^^^^^^^~~^11/1976^</param>
        public FoodNutrients(string csvString)
        {
            csvString = csvString.Replace("~", "");
            string[] csvStringSplit = csvString.Split(StringDelimeter);
            FoodID = Convert.ToInt32(csvStringSplit[0]);
            NutrientID = Convert.ToInt32(csvStringSplit[1]);
            Value = Convert.ToDecimal(csvStringSplit[2]);
        }
    }
}