//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CTDataGenerator.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserTarget
    {
        public UserTarget()
        {
            this.tbl_user_target1 = new HashSet<UserTarget>();
        }
    
        public string TargetID { get; set; }
        public int UserID { get; set; }
        public string MetricID { get; set; }
        public string ParentID { get; set; }
        public System.DateTime GoalTimestamp { get; set; }
        public string CreationTimestamp { get; set; }
        public string CompletedTimestamp { get; set; }
    
        public virtual User tbl_user { get; set; }
        public virtual UserMetric tbl_user_metric { get; set; }
        public virtual ICollection<UserTarget> tbl_user_target1 { get; set; }
        public virtual UserTarget tbl_user_target2 { get; set; }
    }
}