using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using CTDataGenerator.Data;

namespace CTDataGenerator.Utils.CSVImport.FoodImport
{
    public class ImportNutrients
    {
        private const string NutrientFile = "NUTR_DEF.txt";
        private readonly int _startIndex;
        private CTDatabaseContainer _ctEntities;
        private List<Nutrient> _existingNutrients;
        private string _inputLine = string.Empty;

        /// <summary>
        ///     Import Nutrients
        /// </summary>
        public ImportNutrients()
        {
            SetUpImporter();
        }

        /// <summary>
        ///     Import Nutrients With Line Index To start On
        /// </summary>
        /// <param name="startIndex">Start Line Number</param>
        public ImportNutrients(int startIndex)
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
            _existingNutrients = _ctEntities.Nutrients.ToList();
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
            StreamReader streamReader = StreamReaderUtil.CreateStreamReader(NutrientFile);
            int lineIndex = 0;
            while ((_inputLine = streamReader.ReadLine()) != null)
            {
                Debug.WriteLine("Nutrient Line: " + lineIndex);
                if (lineIndex >= _startIndex)
                {
                    var newNutrient = (new Nutrient(_inputLine));
                    if (!NutrientExists(newNutrient)) //If its a new nutrient
                    {
                        AddItemToBeSaved(newNutrient);
                        _existingNutrients.Add(newNutrient);
                    }
                }
                lineIndex++;
            }
            _ctEntities.SaveChanges();
        }

        /// <summary>
        ///     Add A Nutrient To Be Added To DB
        /// </summary>
        /// <param name="nutrient">New Nutrient</param>
        private void AddItemToBeSaved(Nutrient nutrient)
        {
            _ctEntities.Nutrients.Add(nutrient);
            if (_ctEntities.Nutrients.Local.Count%100 == 0)
            {
                _ctEntities.SaveChanges();
                RefreshCTEntities();
            }
        }

        /// <summary>
        ///     Check if Nutrient Has Already Been Entered
        /// </summary>
        /// <param name="newNutrient">Nutrient In Question</param>
        /// <returns>If it exists or not</returns>
        private bool NutrientExists(Nutrient newNutrient)
        {
            for (int i = 0; i < _existingNutrients.Count; i++)
            {
                if (_existingNutrients[i].SourceID.Equals(newNutrient.SourceID)) return true;
            }
            return false;
        }
    }
}