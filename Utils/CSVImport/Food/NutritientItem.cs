using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTDataGenerator.Utils.CSVImport.Food
{
    public class NutritientItem
    {
        private int nutrientID;
        private string nutrientUnitOfMeasure;
        private string nutrientName;
        private int nutrientDecimalRounding;

        public NutritientItem(int nutrientId, string nutrientUnitOfMeasure, string nutrientName, int nutrientDecimalRounding)
        {
            nutrientID = nutrientId;
            this.nutrientUnitOfMeasure = nutrientUnitOfMeasure;
            this.nutrientName = nutrientName;
            this.nutrientDecimalRounding = nutrientDecimalRounding;
        }

        public string NutrientUnitOfMeasure
        {
            get { return nutrientUnitOfMeasure; }
            set { nutrientUnitOfMeasure = value; }
        }

        public string NutrientName
        {
            get { return nutrientName; }
            set { nutrientName = value; }
        }

        public int NutrientDecimalRounding
        {
            get { return nutrientDecimalRounding; }
            set { nutrientDecimalRounding = value; }
        }

        public int NutrientId
        {
            get { return nutrientID; }
            set { nutrientID = value; }
        }
    }
}
