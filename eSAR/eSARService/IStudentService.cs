using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace eSARService
{
    // NOTE: You cna use the "Rename" command on the "Refractor" meno to change the interface name "ISrevice1" in both code and config file together.
    [ServiceContract]
    public interface IStudentService
    {
        [OperationContract]
        Boolean UpdateStudent(ref Student student, ref string message);
        [OperationContract]
        Boolean DismissStudent(string studentID, ref string message);
        [OperationContract]
        Boolean GraduateStudent(string studentID, ref string message);
        [OperationContract]
        Boolean CreateStudent(ref Student student, ref string message);
        [OperationContract]
        List<Student> GetAllStudents();
        [OperationContract]
        Student GetStudent(string studentId, ref string message);
        [OperationContract]
        String GenerateStudentId();

        // TODO: Add your service operation here
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project you can directly use the data types defined there, with the namespace "eSARServince.ContractType".
    [DataContract]
    public class Student
    {
        List<Sibling> sibList = new List<Sibling>();
        [DataMember]
        public string StudentId { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string MiddleName { get; set; }
        [DataMember]
        public Nullable<System.DateTime> DOB { get; set; }
        [DataMember]
        public string POBAddress { get; set; }
        [DataMember]
        public string POBBarangay { get; set; }
        [DataMember]
        public string POBTownCity { get; set; }
        [DataMember]
        public string POBProvince { get; set; }
        [DataMember]
        public string HomeAddress { get; set; }
        [DataMember]
        public string HomeBarangay { get; set; }
        [DataMember]
        public string HomeTownCity { get; set; }
        [DataMember]
        public string HomeProvince { get; set; }
        [DataMember]
        public string SchoolLastAttended { get; set; }
        [DataMember]
        public string FathersName { get; set; }
        [DataMember]
        public string FathersOccupation { get; set; }
        [DataMember]
        public Nullable<double> FathersAverageYearlyIncome { get; set; }
        [DataMember]
        public string FathersEducation { get; set; }
        [DataMember]
        public string MothersMaidenName { get; set; }
        [DataMember]
        public string MothersOccupation { get; set; }
        [DataMember]
        public Nullable<double> MothersAverageYearlyIncome { get; set; }
        [DataMember]
        public string MothersEducation { get; set; }
        [DataMember]
        public string GuardiansName { get; set; }
        [DataMember]
        public string GuardiansOccupation { get; set; }
        [DataMember]
        public Nullable<double> GuardiansAverageYearlyIncome { get; set; }
        [DataMember]
        public Nullable<bool> MadrasahEnrolled { get; set; }
        [DataMember]
        public Nullable<System.DateTime> DateAdmitted { get; set; }
        [DataMember]
        public string GradeLevel { get; set; }
        [DataMember]
        public Nullable<double> Average { get; set; }
        [DataMember]
        public Nullable<bool> Card { get; set; }
        [DataMember]
        public Nullable<bool> GoodMoral { get; set; }
        [DataMember]
        public Nullable<bool> BirthCertificate { get; set; }
        [DataMember]
        public string ScholarshipCode { get; set; }
        [DataMember]
        public string LastSYAttendedDCFI { get; set; }
        [DataMember]
        public Boolean Dismissed { get; set; }
        [DataMember]
        public Boolean Graduate { get; set; }
        [DataMember]
        public string Religion { get; set; }
        [DataMember]
        public byte[] Image { get; set; }
        [DataMember]
        public string Gender { get; set; }
        [DataMember]
        public Scholarship Scholarships { get; set; }

        [DataMember]
        public List<Sibling> Siblings
        {
            get { return sibList; }
            set { sibList = value; }
        }
    }

    [DataContract]
    public class Sibling
    {
        [DataMember]
        public int SiblingId { get; set; }
        [DataMember]
        public string StudentId { get; set; }
        [DataMember]
        public string SiblingStudentId { get; set; }
    }

    [DataContract]
    public class Scholarship
    {
        // List<ScholarshipDiscountBDO> scholarDiscounts = new List<ScholarshipDiscountBDO>();
        [DataMember]
        public string ScholarshipCode { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public string Privilege { get; set; }
        [DataMember]
        public string Condition { get; set; }
        [DataMember]
        public bool Deactivated { get; set; }
        //[DataMember]
        //public List<ScholarshipDiscountBDO> ScholarshipDiscounts
        //{
        //    get { return sholarDiscounts; }
        //    set { sholarDiscounts = value; }
        //}
    }


}
