using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using CTDataGenerator.Data;

namespace CTDataGenerator.Utils.CSVImport.FoodImport
{
    public class ImportFoods
    {
        private const string FoodFile = "FOOD_DES.txt";
        private Dictionary<int, int> _foodGroupSourceIDDictionary;
        private readonly int _startIndex;
        private CTDatabaseContainer _ctEntities;
        private List<Food> _existingFoods;
        private string _inputLine = string.Empty;

        /// <summary>
        ///     Import Foods
        /// </summary>
        /// <param name="foodGroupSourceIDDictionary">Food Source Dictionary</param>
        public ImportFoods(Dictionary<int, int> foodGroupSourceIDDictionary)
        {
            _foodGroupSourceIDDictionary = foodGroupSourceIDDictionary;
            SetUpImporter();
        }

        /// <summary>
        ///     Import Foods With Line Index To start On
        /// </summary>
        /// <param name="startIndex">Start Line Number</param>
        /// <param name="foodGroupSourceIDDictionary">Food Source Dictionary</param>
        public ImportFoods(int startIndex, Dictionary<int, int> foodGroupSourceIDDictionary)
        {
            _startIndex = startIndex;
            _foodGroupSourceIDDictionary = foodGroupSourceIDDictionary;
            SetUpImporter();
        }

        /// <summary>
        ///     Setup Variables for Object
        /// </summary>
        public void SetUpImporter()
        {
            RefreshCTEntities();
            _existingFoods = _ctEntities.Foods.ToList();
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
        ///     Process lines from a file and Extract Food
        /// </summary>
        private void ProcessFromFile()
        {
            StreamReader streamReader = StreamReaderUtil.CreateStreamReader(FoodFile);
            int lineIndex = 0;
            while ((_inputLine = streamReader.ReadLine()) != null)
            {
                Debug.WriteLine("Food Line: " + lineIndex);
                if (lineIndex >= _startIndex)
                {
                    var newFood = (new Food(_inputLine));
                    newFood.GroupID = _foodGroupSourceIDDictionary[newFood.GroupID];
                    if (!FoodExists(newFood)) //If its a new food
                    {
                        AddItemToBeSaved(newFood);
                        _existingFoods.Add(newFood);
                    }
                }
                lineIndex++;
            }
            _ctEntities.SaveChanges();
        }

        /// <summary>
        ///     Add A Food To Be Added To DB
        /// </summary>
        /// <param name="food">New Food</param>
        private void AddItemToBeSaved(Food food)
        {
            _ctEntities.Foods.Add(food);
            if (_ctEntities.Foods.Local.Count%100 == 0)
            {
                _ctEntities.SaveChanges();
                RefreshCTEntities();
            }
        }

        /// <summary>
        ///     Check if Food Has Already Been Entered
        /// </summary>
        /// <param name="newFood">Food In Question</param>
        /// <returns>If it exists or not</returns>
        private bool FoodExists(Food newFood)
        {
            for (int i = 0; i < _existingFoods.Count; i++)
            {
                if (_existingFoods[i].SourceID.Equals(newFood.SourceID)) return true;
            }
            return false;
        }
    }
}