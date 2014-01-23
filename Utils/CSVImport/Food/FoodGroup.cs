using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTDataGenerator.Utils.CSVImport.Food
{
    public class FoodGroup
    {
        private int foodGroupID;
        private string foodGroupName;

        public FoodGroup(int foodGroupId, string foodGroupName)
        {
            foodGroupID = foodGroupId;
            this.foodGroupName = foodGroupName;
        }

        public string FoodGroupName
        {
            get { return foodGroupName; }
            set { foodGroupName = value; }
        }

        public int FoodGroupId
        {
            get { return foodGroupID; }
            set { foodGroupID = value; }
        }
    }
}
