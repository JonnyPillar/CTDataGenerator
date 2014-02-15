using System;

namespace CTDataGenerator.Data
{
    public partial class Nutrient
    {
        private const char StringDelimeter = '^';

        /// <summary>
        ///     Nutrient Constructor
        /// </summary>
        /// <param name="csvString">Line From Data File: Example: ~203~^~g~^~PROCNT~^~Protein~^~2~^~600~ Ignore [2] and > 4</param>
        public Nutrient(string csvString)
        {
            csvString = csvString.Replace("~", "");
            string[] csvStringSplit = csvString.Split(StringDelimeter);
            SourceID = Convert.ToInt32(csvStringSplit[0]);

            string unitType = csvStringSplit[1].ToLower();

            int type = 0;

            if (unitType.Equals("g")) type = 0;
            else if (unitType.Equals("mg")) type = 1;
            else if (unitType.Equals("kcal")) type = 2;
            else if (unitType.Equals("kj")) type = 3;
            else if (unitType.Equals("uq")) type = 4;
            else if (unitType.Equals("iu")) type = 5;

            UnitType = type;
            Name = csvStringSplit[3];
            DecimalRounding = Convert.ToInt32(csvStringSplit[4]);
        }
    }
}