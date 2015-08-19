using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace eSARService
{
    [ServiceContract]
    public interface IFeeService
    {
        [OperationContract]
        Boolean UpdateFee(ref Fee fee, ref string message);
        [OperationContract]
        Boolean CreateFee(ref Fee fee, ref string message);
        [OperationContract]
        List<Fee> GetAllFees();       
    }
    [DataContract]
    public class Fee
    {
        [DataMember]
        public string FeeCode { get; set; }
        [DataMember]
        public string Unit { get; set; }
        [DataMember]
        public string FeeDescription { get; set; }
        [DataMember]
        public bool Deactivated { get; set; }
        [DataMember]
        public Nullable<double> Amount { get; set; }
        [DataMember]
        public Nullable<System.DateTime> DateSet { get; set; }
        [DataMember]
        public string SYImplemented { get; set; }
        [DataMember]
        public string GradeLevel { get; set; }
    }
}
