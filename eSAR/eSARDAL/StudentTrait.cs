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
    
    public partial class StudentTrait
    {
        public string StudentEnrTraitCode { get; set; }
        public string TraitCode { get; set; }
        public string StudentSY { get; set; }
        public Nullable<double> FirstPeriodicRating { get; set; }
        public Nullable<double> SecondPeriodicRating { get; set; }
        public Nullable<double> ThirdPeriodicRating { get; set; }
        public Nullable<double> FourthPeriodicRating { get; set; }
    
        public virtual StudentEnrollment StudentEnrollment { get; set; }
        public virtual Trait Trait { get; set; }
    }
}
