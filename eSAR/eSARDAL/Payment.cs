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
    
    public partial class Payment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Payment()
        {
            this.PaymentDetails = new HashSet<PaymentDetail>();
        }
    
        public int ORNo { get; set; }
        public string StudentId { get; set; }
        public string SettlementFor { get; set; }
        public string ReceivedFrom { get; set; }
        public string TIN { get; set; }
        public string PaidAt { get; set; }
        public string BusinessStyle { get; set; }
        public Nullable<int> PaidTo { get; set; }
        public bool Cancelled { get; set; }
    
        public virtual Student Student { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PaymentDetail> PaymentDetails { get; set; }
    }
}
