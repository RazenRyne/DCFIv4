using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace eSARService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface ITeacherService
    {
        [OperationContract]
        Boolean CreateTeacher(ref Teacher teacher, ref string message);
        [OperationContract]
        Boolean UpdateTeacher(ref Teacher teacher, ref string message);
        [OperationContract]
        List<Teacher> GetAllTeachers();
        [OperationContract]
        List<Teacher> GetFilteredTeachers(string searchType, string search);
        [OperationContract]
        Teacher GetTeacher(string teacherId, ref string message);
        [OperationContract]
        Boolean DeactivateTeacher(string teacherId, ref string message);
        [OperationContract]
        String GenerateTeacherId();
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "eSARService.ContractType".
    [DataContract]
    public class Teacher
    {
        List<TeacherChildren> teachChild = new List<TeacherChildren>();
        List<TeacherEligibility> teachElig = new List<TeacherEligibility>();
        List<TeacherEducationalBackground> educBack = new List<TeacherEducationalBackground>();
        List<TrainingSeminar> trainSem = new List<TrainingSeminar>();
        List<WorkExperience> workExp = new List<WorkExperience>();

        [DataMember]
        public string TeacherId { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string MiddleName { get; set; }
        [DataMember]
        public bool Deactivated { get; set; }
        [DataMember]
        public string Gender { get; set; }
        [DataMember]
        public DateTime DOB { get; set; }
        [DataMember]
        public string TIN { get; set; }
        [DataMember]
        public DateTime DateOfAppointment { get; set; }
        [DataMember]
        public string EmploymentStatus { get; set; }
        [DataMember]
        public string POBProvince { get; set; }
        [DataMember]
        public string POBMunicipality { get; set; }
        [DataMember]
        public string CivilStatus { get; set; }
        [DataMember]
        public int HeightCm { get; set; }
        [DataMember]
        public double WeightKg { get; set; }
        [DataMember]
        public string BloodType { get; set; }
        [DataMember]
        public string SSSNum { get; set; }
        [DataMember]
        public string PagIBIGNo { get; set; }
        [DataMember]
        public string PhilHealthNo { get; set; }
        [DataMember]
        public string RAStreetName { get; set; }
        [DataMember]
        public string RARegion { get; set; }
        [DataMember]
        public string RAProvince { get; set; }
        [DataMember]
        public string RAMunicipality { get; set; }
        [DataMember]
        public string ResTelephoneNo { get; set; }
        [DataMember]
        public string PAStreetName { get; set; }
        [DataMember]
        public string PARegion { get; set; }
        [DataMember]
        public string PAProvince { get; set; }
        [DataMember]
        public string PAMunicipality { get; set; }
        [DataMember]
        public string EmailAddress { get; set; }
        [DataMember]
        public string MobileNo { get; set; }
        [DataMember]
        public string PreviousSchool { get; set; }
        [DataMember]
        public string DialectSpoken { get; set; }
        [DataMember]
        public string SpouseLastName { get; set; }
        [DataMember]
        public string SpouseFirstName { get; set; }
        [DataMember]
        public string SpouseMiddleName { get; set; }
        [DataMember]
        public string SpouseOccupation { get; set; }
        [DataMember]
        public string SpouseBusinessAdd { get; set; }
        [DataMember]
        public string SpouseEmployerName { get; set; }
        [DataMember]
        public string SpouseTelephoneNo { get; set; }
        [DataMember]
        public string PERAA { get; set; }
        [DataMember]
        public byte[] Image;       
        [DataMember]
        public List<TeacherChildren> TeacherChildrens
        {
            get { return teachChild; }
            set { teachChild = value; }
        }
        [DataMember]
        public List<TeacherEducationalBackground> TeacherEducationalBackgrounds
        {
            get { return educBack; }
            set { educBack = value; }
        }
        [DataMember]
        public List<TeacherEligibility> TeacherEligibilities
        {
            get { return teachElig; }
            set { teachElig = value; }
        }
        [DataMember]
        public List<TrainingSeminar> TrainingSeminars
        {
            get { return trainSem; }
            set { trainSem = value; }
        }
            [DataMember]
        public List<WorkExperience> WorkExperiences
        {
            get { return workExp; }
            set { workExp = value; }
        }
    }
    [DataContract]
    public class WorkExperience
    {
        [DataMember]
        public string TeacherId { get; set; }
        [DataMember]
        public int WEId { get; set; }
        [DataMember]
        public DateTime WorkExpFrom { get; set; }
        [DataMember]
        public DateTime WorkExpTo { get; set; }
        [DataMember]
        public string Position { get; set; }
        [DataMember]
        public string CompanyName { get; set; }
        [DataMember]
        public double MonthlySalary { get; set; }
        [DataMember]
        public string StatusOfEmployment { get; set; }

    }
    [DataContract]
    public class TeacherEligibility
    {
        [DataMember]
        public string TeacherId { get; set; }
        [DataMember]
        public int EligibilityId { get; set; }
        [DataMember]
        public string Eligibility { get; set; }
        [DataMember]
        public string Rating { get; set; }
        [DataMember]
        public DateTime DateOfExam { get; set; }
        [DataMember]
        public string PlaceOfExam { get; set; }
        [DataMember]
        public string LicenseNumber { get; set; }
        [DataMember]
        public DateTime IssueDate { get; set; }
    }
    [DataContract]
    public class TeacherEducationalBackground
    {
        [DataMember]
        public string TeacherId { get; set; }
        [DataMember]
        public int TEBId { get; set; }
        [DataMember]
        public string EducLevel { get; set; }
        [DataMember]
        public string NameOfSchool { get; set; }
        [DataMember]
        public DateTime TEBYearFrom { get; set; }
        [DataMember]
        public DateTime TEBYearTo { get; set; }
        [DataMember]
        public string Course { get; set; }
        [DataMember]
        public string HonorsReceived { get; set; }
        [DataMember]
        public bool Deactivated { get; set; }
    }
    [DataContract]
    public class TeacherChildren
    {
        [DataMember]
        public string TeacherId { get; set; }
        [DataMember]
        public int ChildId { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string MiddleName { get; set; }
        [DataMember]
        public DateTime DOB { get; set; }

    }

    [DataContract]
    public class TrainingSeminar
    {
        [DataMember]
        public string TeacherId { get; set; }
        [DataMember]
        public int TSID { get; set; }
        [DataMember]
        public string Title { get; set; }
        [DataMember]
        public string AreaOfTraining { get; set; }
        [DataMember]
        public DateTime DateFrom { get; set; }
        [DataMember]
        public DateTime DateTo { get; set; }
        [DataMember]
        public double NoOfHours { get; set; }
        [DataMember]
        public string ConductedBy { get; set; }

    }
 }
