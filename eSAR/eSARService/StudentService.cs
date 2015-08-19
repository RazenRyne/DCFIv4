using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using eSARLogic;
using eSARBDO;

namespace eSARService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class StudentService : IStudentService
    {
        StudentLogic studentLogic= new StudentLogic();
        public Student GetStudent(string studentId, ref string message)
        {
            Student student= new Student();
            StudentBDO sbdo = studentLogic.GetStudent(studentId);
            
            if (sbdo != null)
            {
                TranslateStudentBDOToStudentDTO(sbdo, student);
            }
            else message = "Student Does Not Exists";

            return student;
        }

        public Boolean CreateStudent(ref Student student, ref string message)
        {
            Boolean ret = false;
            message = String.Empty;
            StudentBDO studentBDO = new StudentBDO();
            TranslateStudentDTOToStudentBDO(student, studentBDO);
            ret = studentLogic.CreateStudent(ref studentBDO, ref message);
            //if (student.Siblings.Count > 0)
            //    studentLogic.CreateSibling(studentBDO.Siblings,studentBDO.StudentId);
            return ret;
        }

        public Boolean UpdateStudent(ref Student student, ref string message)
        {
            message = String.Empty;
            StudentBDO studentBDO = new StudentBDO();
            TranslateStudentDTOToStudentBDO(student, studentBDO);
            return studentLogic.UpdateStudent(ref studentBDO, ref message);
        }

        public List<Student> GetAllStudents()
        {
        
            List<StudentBDO> studentBDOList = studentLogic.GetAllStudents();
            List<Student> allStudents = new List<Student>();
            foreach (StudentBDO studentBDO in studentBDOList)
            {
                Student student = new Student();
                TranslateStudentBDOToStudentDTO(studentBDO, student);
                allStudents.Add(student);
            }
            return allStudents;
        }

        public Boolean DismissStudent(string studentID, ref string message)
        {
        
            message = String.Empty;
            return studentLogic.DismissStudent(studentID, ref message);
        }
        public Boolean GraduateStudent(string studentID, ref string message)
        {
        
            message = String.Empty;
            return studentLogic.GraduateStudent(studentID, ref message);
        }

        public List<SiblingBDO> ToSiblingBDOList(List<Sibling> slist) {
            List<SiblingBDO> sbdoList = new List<SiblingBDO>();
            foreach (Sibling s in slist) {
                SiblingBDO sbdo = new SiblingBDO();
                TranslateSiblingToSiblingBDO(s, sbdo);
                sbdoList.Add(sbdo);
            }
            return sbdoList;
        }


        public void TranslateStudentDTOToStudentBDO(Student student, StudentBDO studentBDO)
        {
            //ScholarshipBDO scho = new ScholarshipBDO();
            //TranslateScholarshipToScholarshipBDO(student.Scholarships, scho);

            //List<SiblingBDO> sibList = ToSiblingBDOList(student.Siblings);

            studentBDO.StudentId = student.StudentId;
            studentBDO.LastName = student.LastName;
            studentBDO.FirstName = student.FirstName;
            studentBDO.MiddleName = student.MiddleName;
            studentBDO.DOB = student.DOB;
            studentBDO.POBAddress = student.POBAddress;
            studentBDO.POBBarangay = student.POBBarangay;
            studentBDO.POBTownCity = student.POBTownCity;
            studentBDO.POBProvince = student.POBProvince;
            studentBDO.HomeAddress = student.HomeAddress;
            studentBDO.HomeBarangay = student.HomeBarangay;
            studentBDO.HomeTownCity = student.HomeTownCity;
            studentBDO.HomeProvince = student.HomeProvince;
            studentBDO.SchoolLastAttended = student.SchoolLastAttended;
            studentBDO.FathersName = student.FathersName;
            studentBDO.FathersOccupation = student.FathersOccupation;
            studentBDO.FathersAverageYearlyIncome = student.FathersAverageYearlyIncome;
            studentBDO.FathersEducation = student.FathersEducation;
            studentBDO.MothersMaidenName = student.MothersMaidenName;
            studentBDO.MothersOccupation = student.MothersOccupation;
            studentBDO.MothersAverageYearlyIncome = student.MothersAverageYearlyIncome;
            studentBDO.MothersEducation = student.MothersEducation;
            studentBDO.GuardiansName = student.GuardiansName;
            studentBDO.GuardiansOccupation = student.GuardiansOccupation;
            studentBDO.GuardiansAverageYearlyIncome = student.GuardiansAverageYearlyIncome;
            studentBDO.MadrasahEnrolled = student.MadrasahEnrolled;
            studentBDO.DateAdmitted = student.DateAdmitted;
            studentBDO.GradeLevel = student.GradeLevel;
            studentBDO.Average = student.Average;
            studentBDO.Card = student.Card;
            studentBDO.GoodMoral = student.GoodMoral;
            studentBDO.BirthCertificate = student.BirthCertificate;
            //studentBDO.ScholarshipCode = student.ScholarshipCode;
            studentBDO.LastSYAttendedDCFI = student.LastSYAttendedDCFI;
            studentBDO.Dismissed = student.Dismissed;
            studentBDO.Graduated = student.Graduate;
            studentBDO.Religion = student.Religion;
            //studentBDO.Scholarship = scho;
            studentBDO.Gender = student.Gender;
            //studentBDO.Siblings = sibList;


            studentBDO.Image = student.Image;
        }

        public void TranslateStudentBDOToStudentDTO(StudentBDO studentBDO, Student student)
        {
            List<Sibling> sibList = new List<Sibling>();
            foreach (SiblingBDO s in studentBDO.Siblings) {
                Sibling sib = new Sibling();
                TranslateSiblingBDOToSibling(s, sib);
                sibList.Add(sib);
            }

            student.StudentId = studentBDO.StudentId;
            student.LastName = studentBDO.LastName;
            student.FirstName = studentBDO.FirstName;
            student.MiddleName = studentBDO.MiddleName;
            student.DOB = studentBDO.DOB;
            student.POBAddress = studentBDO.POBAddress;
            student.POBBarangay = studentBDO.POBBarangay;
            student.POBTownCity = studentBDO.POBTownCity;
            student.POBProvince = studentBDO.POBProvince;
            student.HomeAddress = studentBDO.HomeAddress;
            student.HomeBarangay = studentBDO.HomeBarangay;
            student.HomeTownCity = studentBDO.HomeTownCity;
            student.HomeProvince = studentBDO.HomeProvince;
            student.SchoolLastAttended = studentBDO.SchoolLastAttended;
            student.FathersName = studentBDO.FathersName;
            student.FathersOccupation = studentBDO.FathersOccupation;
            student.FathersAverageYearlyIncome = studentBDO.FathersAverageYearlyIncome;
            student.FathersEducation = studentBDO.FathersEducation;
            student.MothersMaidenName = studentBDO.MothersMaidenName;
            student.MothersOccupation = studentBDO.MothersOccupation;
            student.MothersAverageYearlyIncome = studentBDO.MothersAverageYearlyIncome;
            student.MothersEducation = studentBDO.MothersEducation;
            student.GuardiansName = studentBDO.GuardiansName;
            student.GuardiansOccupation = studentBDO.GuardiansOccupation;
            student.GuardiansAverageYearlyIncome = studentBDO.GuardiansAverageYearlyIncome;
            student.MadrasahEnrolled = studentBDO.MadrasahEnrolled;
            student.DateAdmitted = studentBDO.DateAdmitted;
            student.GradeLevel = studentBDO.GradeLevel;
            student.Average = studentBDO.Average;
            student.Card = studentBDO.Card;
            student.GoodMoral = studentBDO.GoodMoral;
            student.BirthCertificate = studentBDO.BirthCertificate;
            student.ScholarshipCode = studentBDO.ScholarshipCode;
            student.LastSYAttendedDCFI = studentBDO.LastSYAttendedDCFI;
            student.Dismissed = studentBDO.Dismissed;
            student.Graduate = studentBDO.Dismissed;
            student.Religion = studentBDO.Religion;
            student.Image = studentBDO.Image;
            student.Gender = studentBDO.Gender;
            student.Siblings = sibList;
        }

        public void TranslateScholarshipToScholarshipBDO(Scholarship s, ScholarshipBDO sBDO) {
            sBDO.ScholarshipCode = s.ScholarshipCode;
            sBDO.Condition = s.Condition;
            sBDO.Deactivated = s.Deactivated;
            sBDO.Description = s.Description;
            sBDO.Privilege = s.Privilege;
        }

        public void TranslateSiblingToSiblingBDO(Sibling s, SiblingBDO sbdo) {
            sbdo.SiblingId = s.SiblingId;
            sbdo.SiblingStudentId = s.SiblingStudentId;
            sbdo.StudentId = s.StudentId; 
        }

        public void TranslateSiblingBDOToSibling(SiblingBDO s, Sibling sbdo)
        {
            sbdo.SiblingId = s.SiblingId;
            sbdo.SiblingStudentId = s.SiblingStudentId;
            sbdo.StudentId = s.StudentId;
        }


        public String GenerateStudentId() {
            return studentLogic.GenerateStudentId();
        }
    }
}
