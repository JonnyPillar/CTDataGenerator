//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CTDataGenerator.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class FoodGroup
    {
        public FoodGroup()
        {
            this.Foods = new HashSet<Food>();
        }
    
        public int FoodGroupID { get; set; }
        public string Name { get; set; }
        public int SourceID { get; set; }
    
        public virtual ICollection<Food> Foods { get; set; }
    }
}
