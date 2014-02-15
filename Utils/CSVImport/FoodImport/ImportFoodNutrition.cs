using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using CTDataGenerator.Data;

namespace CTDataGenerator.Utils.CSVImport.FoodImport
{
    public class ImportFoodNutrition
    {
        private const string FoodNutrientsFile = "NUT_DATA.txt";
        private readonly int _startIndex;
        private CTDatabaseContainer _ctEntities;
        private Dictionary<int, List<int>> _existingFoodNutrition; //FoodID, <NutrientID>
        private string _inputLine = string.Empty;

        private static Dictionary<int, int> _foodSourceIddDictionary = new Dictionary<int, int>();
        private static Dictionary<int, int> _nutrientSourceIdDictionary = new Dictionary<int, int>();

        /// <summary>
        ///     Import Nutrients
        /// </summary>
        public ImportFoodNutrition(Dictionary<int, int> foodSourceIddDictionary, Dictionary<int, int> nutrientSourceIdDictionary)
        {
            _foodSourceIddDictionary = foodSourceIddDictionary;
            _nutrientSourceIdDictionary = nutrientSourceIdDictionary;
            SetUpImporter();
        }

        /// <summary>
        ///     Import Nutrients With Line Index To start On
        /// </summary>
        /// <param name="startIndex">Start Line Number</param>
        public ImportFoodNutrition(int startIndex, Dictionary<int, int> foodSourceIddDictionary, Dictionary<int, int> nutrientSourceIdDictionary)
        {
            _startIndex = startIndex;
            _foodSourceIddDictionary = foodSourceIddDictionary;
            _nutrientSourceIdDictionary = nutrientSourceIdDictionary;
            SetUpImporter();
        }

        /// <summary>
        ///     Setup Variables for Object
        /// </summary>
        public void SetUpImporter()
        {
            RefreshCTEntities();
            RetreiveExsitingFoodNutrientData();
            _ctEntities = new CTDatabaseContainer();
            ProcessFromFile();
        }

        /// <summary>
        ///     Recreate DB Ojbect
        /// </summary>
        private void RefreshCTEntities()
        {
            _ctEntities = new CTDatabaseContainer();
            _ctEntities.Configuration.AutoDetectChangesEnabled = false;
        }

        /// <summary>
        ///     Process lines from a file and Extract Nutrients
        /// </summary>
        private void ProcessFromFile()
        {
            StreamReader streamReader = StreamReaderUtil.CreateStreamReader(FoodNutrientsFile);
            int lineIndex = 0;
            while ((_inputLine = streamReader.ReadLine()) != null)
            {
                Debug.WriteLine("Food Nutrient Line: " + lineIndex);
                if (lineIndex >= _startIndex)
                {
                    var newFoodNutrient = (new FoodNutrients(_inputLine));
                    newFoodNutrient.FoodID = _foodSourceIddDictionary[newFoodNutrient.FoodID];
                    newFoodNutrient.NutrientID = _nutrientSourceIdDictionary[newFoodNutrient.NutrientID];
                    if (!FoodNutrientExists(newFoodNutrient)) //If its a new foodNutrient
                    {
                        AddItemToBeSaved(newFoodNutrient);
                        AddItemToExistingItemDictionary(newFoodNutrient);
                    }
                }
                lineIndex++;
            }
            _ctEntities.SaveChanges();
        }

        /// <summary>
        ///     Retrieve Existing Food Nutrient Data
        /// </summary>
        private void RetreiveExsitingFoodNutrientData()
        {
            _existingFoodNutrition = new Dictionary<int, List<int>>();
            List<FoodNutrients> foodNutrientList = _ctEntities.FoodNutrients.ToList();
            for (int i = 0; i < foodNutrientList.Count; i++)
            {
                AddItemToExistingItemDictionary(foodNutrientList[i]);
            }
        }

        /// <summary>
        ///     Add A New Food Nutrient To Existing Dictionary
        /// </summary>
        /// <param name="foodNutrient">Food Nutrient</param>
        public void AddItemToExistingItemDictionary(FoodNutrients foodNutrient)
        {
            if (_existingFoodNutrition.ContainsKey(foodNutrient.FoodID))
            {
                _existingFoodNutrition[foodNutrient.FoodID].Add(foodNutrient.NutrientID);
            }
            else _existingFoodNutrition.Add(foodNutrient.FoodID, new List<int> {foodNutrient.NutrientID});
        }

        /// <summary>
        ///     Add A Nutrient To Be Added To DB
        /// </summary>
        /// <param name="foodNutrient">New Nutrient</param>
        private void AddItemToBeSaved(FoodNutrients foodNutrient)
        {
            _ctEntities.FoodNutrients.Add(foodNutrient);
            if (_ctEntities.FoodNutrients.Local.Count%500 == 0)
            {
                try
                {
                    _ctEntities.SaveChanges();
                }
                catch (Exception)
                {
                    _ctEntities.SaveChanges();
                }
                _ctEntities.SaveChanges();
                RefreshCTEntities();
            }
        }

        /// <summary>
        ///     Check if Nutrient Has Already Been Entered
        /// </summary>
        /// <param name="newFoodNutrient">Nutrient In Question</param>
        /// <returns>If it exists or not</returns>
        private bool FoodNutrientExists(FoodNutrients newFoodNutrient)
        {
            if (_existingFoodNutrition.ContainsKey(newFoodNutrient.FoodID))
            {
                List<int> foodNutrientIDList = _existingFoodNutrition[newFoodNutrient.FoodID];
                foreach (int id in foodNutrientIDList)
                {
                    if (id == newFoodNutrient.NutrientID) return true;
                }
            }
            return false;
        }
    }
}