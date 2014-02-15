using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.IO;
using System.Linq;
using CTDataGenerator.Data;

namespace CTDataGenerator.Utils.CSVImport.FoodImport
{
    public class OldFoodCsvImporter
    {
        private const string FoodDescFile = "FOOD_DES.txt";
        private const string NutrientDefinitionFile = "NUTR_DEF.txt";
        private const string FoodGroupFile = "FD_GROUP.txt";
        private const string NutrientDataFile = "NUT_DATA.txt";

        private string ProjectFileURL;
        //private CTEntities ctEntities;

        //private Dictionary<int, int> foodGroupSourceIDDictionary = new Dictionary<int, int>();
        //private Dictionary<int, int> foodSourceIddDictionary = new Dictionary<int, int>();
        //private Dictionary<int, int> nutrientSourceIdDictionary = new Dictionary<int, int>();

        ////Create Food Groups
        ////Create Nutrients
        ////Create Foods
        ////Create Food Nutrient Log

        //public void ProcessFoodDataFiles()
        //{
        //    ctEntities = new CTEntities();
        //    ctEntities.Configuration.AutoDetectChangesEnabled = false;

        //    ProjectFileURL = @"C:\Code\Calorie Tracker\CTDataGenerator\CTDataGenerator\Data\DataFiles";
        //    ProcessFoodGroup();
        //    ProcessNutrients();
        //    ProcessFoods();
        //    ProcessFoodNutrition();
        //    int totalRecorded = ctEntities.SaveChanges();
        //}

        //private void ProcessFoodGroup()
        //{

        //    string fileURL = Path.Combine(ProjectFileURL, FoodGroupFile);
        //    var streamReader = new StreamReader(fileURL);
        //    string fileLine = string.Empty;
        //    int lineNumber = 1;

        //    FoodGroup foodGroup = null;

        //    int numberOfFodGroups = ctEntities.FoodGroups.Count();

        //    //while ((fileLine = streamReader.ReadLine()) != null)
        //    //{
        //    //    Debug.WriteLine("FoodGroup Line: " + lineNumber);
        //    //    if (lineNumber > numberOfFodGroups)
        //    //    {
        //    //        foodGroup = (new FoodGroup(fileLine));
        //    //        ctEntities.FoodGroups.Add(foodGroup);
        //    //        ctEntities.SaveChanges();
        //    //        if (!foodGroupSourceIDDictionary.ContainsKey(foodGroup.SourceID)) foodGroupSourceIDDictionary.Add(foodGroup.SourceID, foodGroup.GroupID);
        //    //    }
        //    //    lineNumber++;
        //    //}
        //}

        //private void ProcessNutrients()
        //{
        //    string fileURL = Path.Combine(ProjectFileURL, NutrientDefinitionFile);
        //    var streamReader = new StreamReader(fileURL);
        //    string fileLine = string.Empty;
        //    int lineNumber = 1;
        //    Nutrient newNutrient = null;

        //    int numberOfNutrients = ctEntities.Nutrients.Count();

        //    //while ((fileLine = streamReader.ReadLine()) != null)
        //    //{
        //    //    Debug.WriteLine("Nutrients Line: " + lineNumber);
        //    //    if (lineNumber > numberOfNutrients)
        //    //    {
        //    //        newNutrient = new Nutrient(fileLine);
        //    //        ctEntities.Nutrients.Add(newNutrient);
        //    //        ctEntities.SaveChanges();
        //    //        nutrientSourceIdDictionary.Add(newNutrient.SourceID, newNutrient.NutrientID);
        //    //    }
        //    //    lineNumber++;
        //    //}
        //    foreach (var nutrient in ctEntities.Nutrients.ToList())
        //    {
        //        nutrientSourceIdDictionary.Add(nutrient.SourceID, nutrient.NutrientID);
        //    }
        //}

        //private void ProcessFoods()
        //{
        //    string fileURL = Path.Combine(ProjectFileURL, FoodDescFile);
        //    var streamReader = new StreamReader(fileURL);
        //    string fileLine = string.Empty;
        //    int lineNumber = 1;

        //    Food newFood = null;

        //    string errorLine = string.Empty;

        //    int numberOfFoods = ctEntities.Foods.Count();
        //    while ((fileLine = streamReader.ReadLine()) != null)
        //    {
        //        Debug.WriteLine("Food Line: " + lineNumber);
        //        if (lineNumber > numberOfFoods)
        //        {
        //            newFood = new Food(fileLine);
        //            newFood.GroupID = foodGroupSourceIDDictionary[newFood.GroupID];
        //            ctEntities.Foods.Add(newFood);


        //            if (lineNumber % 1000 == 0) ctEntities.SaveChanges();
        //        }
        //        lineNumber++;
        //    }
        //    ctEntities.SaveChanges();


        //    foreach (var food in ctEntities.Foods.ToList())
        //    {
        //        foodSourceIddDictionary.Add(food.SourceID, food.FoodID);
        //    }
        //}

        //private void ProcessFoodNutrition()
        //{
        //    string fileURL = Path.Combine(ProjectFileURL, NutrientDataFile);
        //    var streamReader = new StreamReader(fileURL);
        //    string fileLine = string.Empty;
        //    int lineNumber = 1;

        //    int numberOfLogs = ctEntities.FoodNutrientLogs.Count();
        //    string errorLine = string.Empty;
        //    while ((fileLine = streamReader.ReadLine()) != null)
        //    {
        //        Debug.WriteLine("FoodNutrition Line: " + lineNumber);

        //        //if (lineNumber > numberOfLogs)
        //        //{
        //        var newFoodNutrientLog = new FoodNutrientLog(fileLine);

        //        newFoodNutrientLog.FoodID = foodSourceIddDictionary[newFoodNutrientLog.FoodID];
        //        newFoodNutrientLog.NutrientID = nutrientSourceIdDictionary[newFoodNutrientLog.NutrientID];
        //        ctEntities.FoodNutrientLogs.Add(newFoodNutrientLog);

        //        if (lineNumber % 1000 == 0)
        //        {
        //            ctEntities.SaveChanges();
        //            if (lineNumber % 10000 == 0)
        //            {
        //                ctEntities = new CTEntities();
        //                ctEntities.Configuration.AutoDetectChangesEnabled = false;
        //            }
        //        }
        //        //}
        //        lineNumber++;
        //    }
        //    ctEntities.SaveChanges();
        //}

    }
}