using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using CTDataGenerator.Data;

namespace CTDataGenerator.Utils.CSVImport.FoodImport
{
    public class FoodCsvImporter
    {
        private const string FoodDescFile = "FOOD_DES.txt";
        private const string NutrientDefinitionFile = "NUTR_DEF.txt";
        private const string FoodGroupFile = "FD_GROUP.txt";
        private const string NutrientDataFile = "NUT_DATA.txt";
        private string ProjectFileURL;
        private CTEntities ctEntities;

        private Dictionary<int, int> foodGroupSourceIDDictionary = new Dictionary<int, int>(); 

        //Create Food Groups
        //Create Nutrients
        //Create Foods
        //Create Food Nutrient Log

        public void ProcessFoodDataFiles()
        {
            ctEntities = new CTEntities();
            ProjectFileURL = @"C:\Code\Calorie Tracker\CTDataGenerator\CTDataGenerator\Data\DataFiles";
            ProcessFoodGroup();
            ProcessNutrients();
            ProcessFoods();
            ProcessFoodNutrition();
            int totalRecorded = ctEntities.SaveChanges();
        }

        private void ProcessFoodGroup()
        {
            
            string fileURL = Path.Combine(ProjectFileURL, FoodGroupFile);
            var streamReader = new StreamReader(fileURL);
            string fileLine = string.Empty;
            int lineNumber = 1;

            FoodGroup foodGroup = null;

            while ((fileLine = streamReader.ReadLine()) != null)
            {
                Debug.WriteLine("FoodGroup Line: " + lineNumber);

                foodGroup = (new FoodGroup(fileLine));

                

                ctEntities.FoodGroups.Add(foodGroup);

                ctEntities.SaveChanges();

                if (!foodGroupSourceIDDictionary.ContainsKey(foodGroup.SourceID))
                    foodGroupSourceIDDictionary.Add(foodGroup.SourceID, foodGroup.GroupID);

                lineNumber++;
            }
            
        }

        private void ProcessNutrients()
        {
            string fileURL = Path.Combine(ProjectFileURL, NutrientDefinitionFile);
            var streamReader = new StreamReader(fileURL);
            string fileLine = string.Empty;
            int lineNumber = 1;
            while ((fileLine = streamReader.ReadLine()) != null)
            {
                Debug.WriteLine("Nutrients Line: " + lineNumber);
                ctEntities.Nutrients.Add(new Nutrient(fileLine));
                lineNumber++;
            }
            ctEntities.SaveChanges();
        }

        private void ProcessFoods()
        {
            string fileURL = Path.Combine(ProjectFileURL, FoodDescFile);
            var streamReader = new StreamReader(fileURL);
            string fileLine = string.Empty;
            int lineNumber = 1;

            Food newFood = null;
            while ((fileLine = streamReader.ReadLine()) != null)
            {
                Debug.WriteLine("Food Line: " + lineNumber);

                newFood = new Food(fileLine);
                newFood.GroupID = foodGroupSourceIDDictionary[newFood.GroupID];

                ctEntities.Foods.Add(newFood);
                lineNumber++;
                if(lineNumber % 400 == 0) ctEntities.SaveChanges();
                //ctEntities.SaveChanges();
            }

            ctEntities.SaveChanges();
        }

        private void ProcessFoodNutrition()
        {
            string fileURL = Path.Combine(ProjectFileURL, NutrientDataFile);
            var streamReader = new StreamReader(fileURL);
            string fileLine = string.Empty;
            int lineNumber = 1;

            Food existingFood = null;
            Nutrient existingNutrient = null;

            while ((fileLine = streamReader.ReadLine()) != null)
            {
                Debug.WriteLine("FoodNutrition Line: " + lineNumber);
                var newFoodNutrientLog = new FoodNutrientLog(fileLine);
                //existingFood = null;
                //existingFood = ctEntities.Foods.SingleOrDefault(food => food.SourceID == newFoodNutrientLog.FoodID);
                //if (existingFood != null) newFoodNutrientLog.Food = existingFood;

                //existingNutrient = null;
                //existingNutrient = ctEntities.Nutrients.SingleOrDefault(nutrient => nutrient.SourceID == newFoodNutrientLog.NutrientID);
                //if (existingNutrient != null) newFoodNutrientLog.Nutrient = existingNutrient;

                ctEntities.FoodNutrientLogs.Add(newFoodNutrientLog);
                lineNumber++;
                if (lineNumber % 400 == 0) ctEntities.SaveChanges();
            }
        }
    }
}