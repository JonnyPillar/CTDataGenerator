using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using CTDataGenerator.Data;

namespace CTDataGenerator.Utils.CSVImport.FoodImport
{
    public class ImportFoodGroups
    {
        private const string FoodGroupFile = "FD_GROUP.txt";
        private readonly int _startIndex;
        private CTDatabaseContainer _ctEntities;
        private List<FoodGroup> _existingFoodGroups;
        private string _inputLine = string.Empty;

        /// <summary>
        ///     Import Food Group
        /// </summary>
        public ImportFoodGroups()
        {
            SetUpImporter();
        }

        /// <summary>
        ///     Import Food Group With Line Index To start On
        /// </summary>
        /// <param name="startIndex">Start Line Number</param>
        public ImportFoodGroups(int startIndex)
        {
            _startIndex = startIndex;
            SetUpImporter();
        }

        /// <summary>
        ///     Setup Variables for Object
        /// </summary>
        public void SetUpImporter()
        {
            RefreshCTEntities();
            _existingFoodGroups = _ctEntities.FoodGroups.ToList();
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
        ///     Process lines from a file and Extract Food Groups
        /// </summary>
        private void ProcessFromFile()
        {
            StreamReader streamReader = StreamReaderUtil.CreateStreamReader(FoodGroupFile);
            int lineIndex = 0;
            while ((_inputLine = streamReader.ReadLine()) != null)
            {
                Debug.WriteLine("Food Group Line: " + lineIndex);
                if (lineIndex >= _startIndex)
                {
                    var newFoodGroup = (new FoodGroup(_inputLine));
                    if (!FoodGroupExists(newFoodGroup)) //If its a new Food Group
                    {
                        AddItemToBeSaved(newFoodGroup);
                        _existingFoodGroups.Add(newFoodGroup);
                    }
                }
                lineIndex++;
            }
            _ctEntities.SaveChanges();
        }

        /// <summary>
        ///     Add A Food Group To Be Added To DB
        /// </summary>
        /// <param name="foodGroup">New Food Group</param>
        private void AddItemToBeSaved(FoodGroup foodGroup)
        {
            _ctEntities.FoodGroups.Add(foodGroup);
            if (_ctEntities.FoodGroups.Local.Count%100 == 0)
            {
                _ctEntities.SaveChanges();
                RefreshCTEntities();
            }
        }

        /// <summary>
        ///     Check if Food Group Has Already Been Entered
        /// </summary>
        /// <param name="foodGroup">Food Group In Question</param>
        /// <returns>If it exists or not</returns>
        private bool FoodGroupExists(FoodGroup foodGroup)
        {
            for (int i = 0; i < _existingFoodGroups.Count; i++)
            {
                if (_existingFoodGroups[i].SourceID.Equals(foodGroup.SourceID)) return true;
            }
            return false;
        }
    }
}