using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eSARBDO;

namespace eSARDAL
{
    public class StudentDAO
    {
        public StudentBDO GetStudentBDO(string studentID)
        {
            StudentBDO studentBDO = null;
            using (var DCEnt = new DCFIEntities())
            {
                Student student = (from s in DCEnt.Students
                                   where s.StudentId == studentID 
                                   select s).FirstOrDefault();
                if (student != null)
                {
                    studentBDO = new StudentBDO();
                    ConvertStudentToStudentBDO(student, studentBDO);
                }
            }
            return studentBDO;
        }

        public List<SiblingBDO> GetSiblings(string studentId) {
            List<SiblingBDO> sibList = new List<SiblingBDO>();
           List<Sibling> sib = new List<Sibling>();
            using (var DCEnt = new DCFIEntities()) {
                sib= (from s in DCEnt.Siblings
                            where s.StudentId.Equals(studentId)
                            select s).ToList<Sibling>();
            }
            sibList = ToSiblingBDOList(sib);
            return sibList;
        }

        public Student GetStudent(string studentID)
        {
            Student student = null;
            using (var DCEnt = new DCFIEntities())
            {
                student = (from s in DCEnt.Students
                        where s.StudentId == studentID
                        select s).FirstOrDefault();
            }

            return student;
        }

        public List<StudentBDO> GetAllStudents()
        {
            List<Student> studentList = new List<Student>();
            using (var DCEnt = new DCFIEntities())
            {
                var allStudents = (DCEnt.Students);
                studentList = allStudents.ToList<Student>();
            }
                //studentList = (from s in DCEnt.Students
                //               where s.Dismissed == false
                //               && s.LastSYAttendedDCFI == (DateTime.Now.Year - 1).ToString()
                //               select s).ToList<Student>();}

                List<StudentBDO> studentBDOList = new List<StudentBDO>();
            foreach (Student s in studentList)
            {
                StudentBDO studentBDO = new StudentBDO();
                ConvertStudentToStudentBDO(s, studentBDO);
                studentBDOList.Add(studentBDO);
            }
            return studentBDOList;
        }

        public Boolean CreateStudent(ref StudentBDO studentBDO, ref string message)
        {
            message = "Student Added Successfully";
            bool ret = true;

            Student s = new Student();
            ConvertStudentBDOToStudent(studentBDO, s);

            using (var DCEnt = new DCFIEntities())
            {
                DCEnt.Students.Attach(s);
                DCEnt.Entry(s).State = System.Data.Entity.EntityState.Added;
                int num = DCEnt.SaveChanges();
                studentBDO.StudentId = s.StudentId;

                if  (num != 1)
                {
                    ret = false;
                    message = "Adding of User failed";
                }
            }
            return ret;
        }

        public Boolean CreateSibling(List<SiblingBDO> sbdo, string studentId)
        {
            Boolean ret = true;
            foreach (SiblingBDO s in sbdo)
            {
                Sibling sib = new Sibling();
                ConvertSiblingBDOToSibling(s, sib, studentId);
                using (var DCEnt = new DCFIEntities())
                {
                    DCEnt.Siblings.Attach(sib);
                    int num = DCEnt.SaveChanges();
                    if (num != 1)
                        ret = false;
                }
            }
            return ret;
        }


        public Boolean UpdateStudent(ref StudentBDO studentBDO, ref string message)
        {
            message = "Student updated successfully.";
            Boolean ret = true;
            using (var DCEnt = new DCFIEntities())
            {
                var studentID = studentBDO.StudentId;
                Student studentInDB = (from s in DCEnt.Students
                                       where s.StudentId == studentID
                                       select s).FirstOrDefault();
                if (studentInDB == null)
                {
                    throw new Exception("No student with ID " + studentBDO.StudentId);

                }

                DCEnt.Students.Remove(studentInDB);

                studentInDB.StudentId = studentBDO.StudentId;
                studentInDB.LastName = studentBDO.LastName;
                studentInDB.FirstName = studentBDO.FirstName;
                studentInDB.MiddleName = studentBDO.MiddleName;
                studentInDB.DOB = studentBDO.DOB;
                studentInDB.POBAddress = studentBDO.POBAddress;
                studentInDB.POBBarangay = studentBDO.POBBarangay;
                studentInDB.POBTownCity = studentBDO.POBTownCity;
                studentInDB.POBProvince = studentBDO.POBProvince;
                studentInDB.HomeAddress = studentBDO.HomeAddress;
                studentInDB.HomeBarangay = studentBDO.HomeBarangay;
                studentInDB.HomeTownCity = studentBDO.HomeTownCity;
                studentInDB.HomeProvince = studentBDO.HomeProvince;
                studentInDB.SchoolLastAttended = studentBDO.SchoolLastAttended;
                studentInDB.FathersName = studentBDO.FathersName;
                studentInDB.FathersOccupation = studentBDO.FathersOccupation;
                studentInDB.FathersAverageYearlyIncome = studentBDO.FathersAverageYearlyIncome;
                studentInDB.FathersEducation = studentBDO.FathersEducation;
                studentInDB.MothersMaidenName = studentBDO.MothersMaidenName;
                studentInDB.MothersOccupation = studentBDO.MothersOccupation;
                studentInDB.MothersAverageYearlyIncome = studentBDO.MothersAverageYearlyIncome;
                studentInDB.MothersEducation = studentBDO.MothersEducation;
                studentInDB.GuardiansName = studentBDO.GuardiansName;
                studentInDB.GuardiansOccupation = studentBDO.GuardiansOccupation;
                studentInDB.GuardiansAverageYearlyIncome = studentBDO.GuardiansAverageYearlyIncome;
                studentInDB.MadrasahEnrolled = studentBDO.MadrasahEnrolled;
                studentInDB.DateAdmitted = studentBDO.DateAdmitted;
                studentInDB.GradeLevel = studentBDO.GradeLevel;
                studentInDB.Average = studentBDO.Average;
                studentInDB.Card = studentBDO.Card;
                studentInDB.GoodMoral = studentBDO.GoodMoral;
                studentInDB.BirthCertificate = studentBDO.BirthCertificate;
                studentInDB.ScholarshipCode = studentBDO.ScholarshipCode;
                studentInDB.LastSYAttendedDCFI = studentBDO.LastSYAttendedDCFI;
                studentInDB.Dismissed = studentBDO.Dismissed;
                studentInDB.Graduated = studentBDO.Dismissed;
                studentInDB.Religion = studentBDO.Religion;
                studentInDB.Image = studentBDO.Image;
                
                DCEnt.Students.Attach(studentInDB);
                DCEnt.Entry(studentInDB).State = System.Data.Entity.EntityState.Modified;
                int num = DCEnt.SaveChanges();

                if (num != 1)
                {
                    ret = false;
                    message = "No student is updated.";
                }
            }
            return ret;

        }


        public Boolean DismissStudent(string studentID, ref string message)
        {
            message = "Student dismissed successfully.";
            Boolean ret = true;

            using (var DCEnt = new DCFIEntities())
            {
                Student studentInDB = (from s in DCEnt.Students
                                       where s.StudentId == studentID
                                       select s).FirstOrDefault();
                if (studentInDB == null)
                {
                    throw new Exception("No student with ID " + studentID);
                }

                DCEnt.Students.Remove(studentInDB);

                studentInDB.Dismissed = true;

                DCEnt.Students.Attach(studentInDB);
                DCEnt.Entry(studentInDB).State = System.Data.Entity.EntityState.Modified;
                int num = DCEnt.SaveChanges();
                if (num != 1)
                {
                    ret = false;
                    message = "Fail to Dismiss Student.";
                }
            }
            return ret; 
        }

        public Boolean GraduateStudent(string studentID, ref string message)
        {
            message = "User Retained successfully.";
            Boolean ret = true;

            using (var DCEnt = new DCFIEntities())
            {
                Student studentInDB = (from s in DCEnt.Students
                                       where s.StudentId == studentID
                                       select s).FirstOrDefault();

                if (studentInDB == null)
                {
                    throw new Exception("No student with ID " + studentID);
                }

                DCEnt.Students.Remove(studentInDB);

                studentInDB.Graduated = false;

                DCEnt.Students.Attach(studentInDB);
                DCEnt.Entry(studentInDB).State = System.Data.Entity.EntityState.Modified;
                int num = DCEnt.SaveChanges();
                if (num != 1)
                {
                    ret = false;
                    message = "Changing Graduate Status Failed.";
                }
            }
            return ret;
        }

        private void ConvertSiblingBDOToSibling(SiblingBDO s, Sibling sib,string studentId) {
            sib.StudentId = studentId;
            sib.SiblingStudentId = s.SiblingStudentId;
        }

        private void ConvertSiblingToSiblingBDO(Sibling s, SiblingBDO sib)
        {
            sib.SiblingId = s.SiblingId;
            sib.StudentId = s.StudentId;
            sib.SiblingStudentId = s.SiblingStudentId;
        }

        private void ConvertStudentToStudentBDO(Student s, StudentBDO sbdo) {
             sbdo.Average = s.Average;
            sbdo.BirthCertificate = s.BirthCertificate;
            sbdo.Card = s.Card;
            sbdo.DateAdmitted = s.DateAdmitted;
            sbdo.Dismissed = s.Dismissed;
            sbdo.DOB = s.DOB;
            sbdo.FathersAverageYearlyIncome = s.FathersAverageYearlyIncome;
            sbdo.FathersEducation = s.FathersEducation;
            sbdo.FathersName = s.FathersName;
            sbdo.FathersOccupation = s.FathersOccupation;
            sbdo.FirstName = s.FirstName;
            sbdo.GoodMoral = s.GoodMoral;
            sbdo.GradeLevel = s.GradeLevel;
            sbdo.Graduated = s.Graduated;
            sbdo.GuardiansAverageYearlyIncome = s.GuardiansAverageYearlyIncome;
            sbdo.GuardiansName = s.GuardiansName;
            sbdo.GuardiansOccupation = s.GuardiansOccupation;
            sbdo.HomeAddress = s.HomeAddress;
            sbdo.HomeBarangay = s.HomeBarangay;
            sbdo.HomeProvince = s.HomeProvince;
            sbdo.HomeTownCity = s.HomeTownCity;
            sbdo.Image = s.Image;
            sbdo.LastName = s.LastName;
            sbdo.LastSYAttendedDCFI = s.LastSYAttendedDCFI;
            sbdo.MadrasahEnrolled = s.MadrasahEnrolled;
            sbdo.MiddleName = s.MiddleName;
            sbdo.MothersAverageYearlyIncome = s.MothersAverageYearlyIncome;
            sbdo.MothersEducation = s.MothersEducation;
            sbdo.MothersMaidenName = s.MothersMaidenName;
            sbdo.MothersOccupation = s.MothersOccupation;
            sbdo.POBAddress = s.POBAddress;
            sbdo.POBBarangay = s.POBBarangay;
            sbdo.POBProvince = s.POBProvince;
            sbdo.POBTownCity = s.POBTownCity;
            sbdo.Religion = s.Religion;
            //sbdo.Scholarship = s.Scholarship;
            sbdo.ScholarshipCode = s.ScholarshipCode;
            sbdo.SchoolLastAttended = s.SchoolLastAttended;
            // sbdo.Siblings = s.Siblings;
            sbdo.StudentId = s.StudentId;
            sbdo.Gender = s.Gender;
        }


        private void ConvertStudentBDOToStudent(StudentBDO s, Student sbdo)
        {
            //ICollection<Sibling> sib = new List<Sibling>();
           // sib = ToSiblingList(s.Siblings);
            sbdo.FirstName = s.FirstName;
            sbdo.StudentId = s.StudentId;
            sbdo.Average = s.Average;
            sbdo.BirthCertificate = s.BirthCertificate;
            sbdo.Card = s.Card;
            sbdo.DateAdmitted = s.DateAdmitted;
            sbdo.Dismissed = s.Dismissed;
            sbdo.DOB = s.DOB;
            sbdo.FathersAverageYearlyIncome = s.FathersAverageYearlyIncome;
            sbdo.FathersEducation = s.FathersEducation;
            sbdo.FathersName = s.FathersName;
            sbdo.FathersOccupation = s.FathersOccupation;
            sbdo.GoodMoral = s.GoodMoral;
            sbdo.GradeLevel = s.GradeLevel;
            sbdo.Graduated = s.Graduated;
            sbdo.GuardiansAverageYearlyIncome = s.GuardiansAverageYearlyIncome;
            sbdo.GuardiansName = s.GuardiansName;
            sbdo.GuardiansOccupation = s.GuardiansOccupation;
            sbdo.HomeAddress = s.HomeAddress;
            sbdo.HomeBarangay = s.HomeBarangay;
            sbdo.HomeProvince = s.HomeProvince;
            sbdo.HomeTownCity = s.HomeTownCity;
            sbdo.Image = s.Image;
            sbdo.LastName = s.LastName;
            sbdo.LastSYAttendedDCFI = s.LastSYAttendedDCFI;
            sbdo.MadrasahEnrolled = s.MadrasahEnrolled;
            sbdo.MiddleName = s.MiddleName;
            sbdo.MothersAverageYearlyIncome = s.MothersAverageYearlyIncome;
            sbdo.MothersEducation = s.MothersEducation;
            sbdo.MothersMaidenName = s.MothersMaidenName;
            sbdo.MothersOccupation = s.MothersOccupation;
            sbdo.POBAddress = s.POBAddress;
            sbdo.POBBarangay = s.POBBarangay;
            sbdo.POBProvince = s.POBProvince;
            sbdo.POBTownCity = s.POBTownCity;
            sbdo.Religion = s.Religion;
            //sbdo.Scholarship = s.Scholarship;
            //sbdo.ScholarshipCode = s.ScholarshipCode;
            sbdo.SchoolLastAttended = s.SchoolLastAttended;
            sbdo.Gender = s.Gender;
        }

        private List<SiblingBDO> ToSiblingBDOList(List<Sibling> siblings) {
            List<SiblingBDO> sibList = new List<SiblingBDO>();
            foreach (Sibling s in siblings) {
                SiblingBDO sbdo = new SiblingBDO();
                ConvertSiblingToSiblingBDO(s, sbdo);
                sibList.Add(sbdo);
            }
            return sibList;
        }

        private List<Sibling> ToSiblingList(List<SiblingBDO> siblings)
        {
            List<Sibling> sibList = new List<Sibling>();
            foreach (SiblingBDO s in siblings)
            {
                Sibling sbdo = new Sibling();
                ConvertSiblingBDOToSibling(s, sbdo,s.StudentId);
                sibList.Add(sbdo);
            }
            return sibList;
        }



        public string GetLatestStudentId()
        {
            string studentId = "none";
            using (var DCEnt = new DCFIEntities())
            {
                studentId = (from s in DCEnt.Students
                             orderby s.StudentId descending
                             select s.StudentId).FirstOrDefault();
            }

            if (studentId == null) studentId = "none";

            return studentId;
        }

    }
}
