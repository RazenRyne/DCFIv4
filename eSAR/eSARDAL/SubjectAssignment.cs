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
    
    public partial class SubjectAssignment
    {
        public int SubjectAssignmentNumber { get; set; }
        public string SY { get; set; }
        public string SubjectCode { get; set; }
        public string TimeSlotCode { get; set; }
        public string RoomCode { get; set; }
        public string TeacherId { get; set; }
        public Nullable<int> GradeSectionCode { get; set; }
        public Nullable<bool> Deactivated { get; set; }
    
        public virtual GradeSection GradeSection { get; set; }
        public virtual Room Room { get; set; }
        public virtual Subject Subject { get; set; }
        public virtual Teacher Teacher { get; set; }
        public virtual Timeslot Timeslot { get; set; }
    }
}
