using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTDataGenerator.Utils.CSVImport.Food
{
    public class FoodNutrient
    {
        private int foodNutrientFoodID;
        private int foodNutrientNutrientID;
        private decimal foodNutrientValue; //Per 100g

        public FoodNutrient(int foodNutrientFoodId, int foodNutrientNutrientId, decimal foodNutrientValue)
        {
            foodNutrientFoodID = foodNutrientFoodId;
            foodNutrientNutrientID = foodNutrientNutrientId;
            this.foodNutrientValue = foodNutrientValue;
        }

        public int FoodNutrientFoodId
        {
            get { return foodNutrientFoodID; }
            set { foodNutrientFoodID = value; }
        }

        public decimal FoodNutrientValue
        {
            get { return foodNutrientValue; }
            set { foodNutrientValue = value; }
        }

        public int FoodNutrientNutrientId
        {
            get { return foodNutrientNutrientID; }
            set { foodNutrientNutrientID = value; }
        }
    }
}
