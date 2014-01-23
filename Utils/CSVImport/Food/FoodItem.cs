using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTDataGenerator.Utils.CSVImport.Food
{
    /// <summary>
    /// Relates to the FOOD_DES.txt file
    /// NDB_No, FdGrp_Cd, Long_Desc, Shrt_Desc, ManufacName
    /// </summary>
    public class FoodItem
    {
        private int foodID;
        private int foodGroupID;
        private string foodLongDescription;
        private string foodShortDescription;
        private string foodManufactureName;

        public FoodItem(int foodId, int foodGroupId, string foodShortDescription, string foodLongDescription, string foodManufactureName)
        {
            foodID = foodId;
            foodGroupID = foodGroupId;
            this.foodShortDescription = foodShortDescription;
            this.foodLongDescription = foodLongDescription;
            this.foodManufactureName = foodManufactureName;
        }

        public int FoodId
        {
            get { return foodID; }
            set { foodID = value; }
        }

        public int FoodGroupId
        {
            get { return foodGroupID; }
            set { foodGroupID = value; }
        }

        public string FoodLongDescription
        {
            get { return foodLongDescription; }
            set { foodLongDescription = value; }
        }

        public string FoodShortDescription
        {
            get { return foodShortDescription; }
            set { foodShortDescription = value; }
        }

        public string FoodManufactureName
        {
            get { return foodManufactureName; }
            set { foodManufactureName = value; }
        }
    }
}
