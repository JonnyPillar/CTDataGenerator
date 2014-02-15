using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTDataGenerator.Data
{
    partial class FoodLog
    {
        public FoodLog(int foodID, int userID)
        {
            FoodID = foodID;
            UserID = userID;
            CreationTimestamp = DateTime.Now;
        }
    }
}
