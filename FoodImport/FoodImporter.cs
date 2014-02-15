using System.Collections.Generic;
using System.Linq;
using CTDataGenerator.Data;
using CTDataGenerator.Utils.CSVImport.FoodImport;

namespace CTDataGenerator.FoodImport
{
    public class FoodImporter
    {
        private static CTDatabaseContainer _ctEntities = new CTDatabaseContainer();

        private static Dictionary<int, int> _foodGroupSourceIDDictionary = new Dictionary<int, int>();
        private static Dictionary<int, int> _foodSourceIddDictionary = new Dictionary<int, int>();
        private static Dictionary<int, int> _nutrientSourceIdDictionary = new Dictionary<int, int>();

        //Load existing
        public static void ProcessFoodDataFiles()
        {
            var importFoodGroups = new ImportFoodGroups();
            _foodGroupSourceIDDictionary = RetrieveFoodGroupInformation();

            var importFoodNutrients = new ImportNutrients();
            _nutrientSourceIdDictionary = RetrieveNutrientInformation();

            var importFoods = new ImportFoods(_foodGroupSourceIDDictionary);
            _foodSourceIddDictionary = RetrieveFoodInformation();

            var importFoodNutrition = new ImportFoodNutrition(200000, _foodSourceIddDictionary, _nutrientSourceIdDictionary);
        }

        private static Dictionary<int, int> RetrieveFoodGroupInformation()
        {
            List<FoodGroup> foodGroupList = _ctEntities.FoodGroups.ToList();
            var foodGroupDictionary = new Dictionary<int, int>();
            foreach (FoodGroup existingFoodGroup in foodGroupList)
            {
                if (!foodGroupDictionary.ContainsKey(existingFoodGroup.SourceID))
                {
                    foodGroupDictionary.Add(existingFoodGroup.SourceID, existingFoodGroup.FoodGroupID);
                }
            }
            return foodGroupDictionary;
        }

        private static Dictionary<int, int> RetrieveNutrientInformation()
        {
            List<Nutrient> nutrientList = _ctEntities.Nutrients.ToList();
            var nutrientDictionary = new Dictionary<int, int>();
            foreach (Nutrient existingNutrient in nutrientList)
            {
                if (!nutrientDictionary.ContainsKey(existingNutrient.SourceID))
                {
                    nutrientDictionary.Add(existingNutrient.SourceID, existingNutrient.NutrientID);
                }
            }
            return nutrientDictionary;
        }

        private static Dictionary<int, int> RetrieveFoodInformation()
        {
            List<Food> foodList = _ctEntities.Foods.ToList();
            var foodDictionary = new Dictionary<int, int>();
            foreach (Food existingFood in foodList)
            {
                if (!foodDictionary.ContainsKey(existingFood.SourceID))
                {
                    foodDictionary.Add(existingFood.SourceID, existingFood.FoodID);
                }
            }
            return foodDictionary;
        }
    }
}