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
    
    public partial class CurriculumSubject
    {
        public string CurrSubCode { get; set; }
        public string SubjectCode { get; set; }
        public string CurriculumCode { get; set; }
        public bool Deactivated { get; set; }
        public Nullable<int> NumberOfUnits { get; set; }
    
        public virtual Curriculum Curriculum { get; set; }
        public virtual Subject Subject { get; set; }
    }
}
