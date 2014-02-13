using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CTDataGenerator.Data;
using CTDataGenerator.Utils.CSVImport.FoodImport;

namespace CTDataGenerator.FoodImport
{
    public class FoodImporter
    {
        private static string _projectFileURL;
        private static CTDatabaseContainer _ctEntities;

        private static Dictionary<int, int> foodGroupSourceIDDictionary = new Dictionary<int, int>();
        private static Dictionary<int, int> foodSourceIddDictionary = new Dictionary<int, int>();
        private static Dictionary<int, int> nutrientSourceIdDictionary = new Dictionary<int, int>(); 

        //Load existing
        public static void ProcessFoodDataFiles()
        {
            foodGroupSourceIDDictionary = ImportFoodGroups.ProcessFoodGroupsFromFile(0);



            //ProcessFoodGroup();
            //ProcessNutrients();
            //ProcessFoods();
            //ProcessFoodNutrition();
            //int totalRecorded = ctEntities.SaveChanges();
        }
    }
}
