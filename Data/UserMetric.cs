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
    
    public partial class UserMetric
    {
        public UserMetric()
        {
            this.tbl_metric_log = new HashSet<MetricLog>();
            this.tbl_user_target = new HashSet<UserTarget>();
        }
    
        public string MetricID { get; set; }
        public string MetricName { get; set; }
        public sbyte MetricType { get; set; }
    
        public virtual ICollection<MetricLog> tbl_metric_log { get; set; }
        public virtual ICollection<UserTarget> tbl_user_target { get; set; }
    }
}
