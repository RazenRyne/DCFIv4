//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace eSARDAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class ScholarshipDiscount
    {
        public string ScholarshipFeeCode { get; set; }
        public string ScholarshipCode { get; set; }
        public string FeeCode { get; set; }
        public Nullable<double> Discount { get; set; }
        public bool Deactivated { get; set; }
        public int ScholarshipDiscountId { get; set; }
    
        public virtual Fee Fee { get; set; }
        public virtual Scholarship Scholarship { get; set; }
    }
}