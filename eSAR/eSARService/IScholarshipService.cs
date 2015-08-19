using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace eSARService
{
    [ServiceContract]
    public interface IScholarshipService
    {
        [OperationContract]
        List<Scholarship> GetAllScholarships();
        [OperationContract]
        Boolean CreateScholarship(ref Scholarship scholarship, ref string message);
        [OperationContract]
        Boolean AddScholarshipDiscount(ref ScholarshipDiscount scholarshipDiscount, string scholarshipCode, ref string message);
        [OperationContract]
        Boolean UpdateScholarship(ref Scholarship scholarship, ref string message);
        [OperationContract]
        List<Student> GetAllScholarsOfScholarship(string scholarshipCode);
        [OperationContract]
        List<Student> GetAllScholars();
        [OperationContract]
        List<ScholarshipDiscount> GetAllScholarshipDiscount(string scholarshipCode);
        [OperationContract]
        Boolean DeleteScholarshipDiscount(string scholarshipFeeCode, string scholarshipCode);
        [OperationContract]
        Boolean UpdateScholarshipDiscount(ref ScholarshipDiscount scholarshipDiscount, ref string message);
    }

    [DataContract]
    public class ScholarshipDiscount
    {
        [DataMember]
        public string ScholarshipFeeCode { get; set; }
        [DataMember]
        public string ScholarshipCode { get; set; }
        [DataMember]
        public string FeeCode { get; set; }
        [DataMember]
        public Nullable<double> Discount { get; set; }
        [DataMember]
        public bool Deactivated { get; set; }
        [DataMember]
        public Fee Fee { get; set; }

    }
}
