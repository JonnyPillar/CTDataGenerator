using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using CTDataGenerator.Data;

namespace CTDataGenerator.Utils.CSVImport.FoodImport
{
    public class ImportFoodGroups
    {
        private const string FoodGroupFile = "FD_GROUP.txt";
        private static string _inputLine = string.Empty;
        private static readonly Dictionary<int, int> FoodGroupDictionary = new Dictionary<int, int>();
        //SourceID, GroupID

        /// <summary>
        ///     Create Food Group From CSV File
        /// </summary>
        /// <param name="inputLine">Input String</param>
        /// <returns>Dictionary Containing The SourceID and its related GroupID</returns>
        public static Dictionary<int, int> ProcessFoodGroupsFromString(string inputLine)
        {
            CreateFoodGroup(inputLine);
            return FoodGroupDictionary;
        }

        /// <summary>
        ///     Create Food Group From CSV File
        /// </summary>
        /// <param name="startCount">Line To Start On</param>
        /// <returns>Dictionary Containing The SourceID and its related GroupID</returns>
        public static Dictionary<int, int> ProcessFoodGroupsFromFile(int startCount)
        {
            StreamReader streamReader = StreamReaderUtil.CreateStreamReader(FoodGroupFile);
            int lineNumber = 1;
            FoodGroup foodGroup = null;

            while ((_inputLine = streamReader.ReadLine()) != null)
            {
                Debug.WriteLine("FoodGroup Line: " + lineNumber);
                if (lineNumber >= startCount)
                {
                    CreateFoodGroup(_inputLine);
                }
                lineNumber++;
            }
            return FoodGroupDictionary;
        }

        /// <summary>
        ///     Create New Food Group, Save it to DB
        /// </summary>
        /// <param name="inputLine">Input String</param>
        private static void CreateFoodGroup(string inputLine)
        {
            var ctEntities = new CTDatabaseContainer();
            ctEntities.Configuration.AutoDetectChangesEnabled = false;

            var foodGroup = (new FoodGroup(inputLine));

            ctEntities.FoodGroups.Add(foodGroup);
            ctEntities.SaveChanges(); //Save each time for this instance. This has a low count so no large performance difference

            if (!FoodGroupDictionary.ContainsKey(foodGroup.SourceID))
            {
                FoodGroupDictionary.Add(foodGroup.SourceID, foodGroup.FoodGroupID);
            }
        }
    }
}