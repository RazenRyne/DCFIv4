using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eSARBDO;

namespace eSARDAL
{
    public class ScholarshipDAO
    {
        public List<ScholarshipBDO> GetAllScholarships()
        {
            List<Scholarship> sList = new List<Scholarship>();
            using (var DCEnt = new DCFIEntities())
            {
                var allScholarships = (DCEnt.Scholarships);
                sList = allScholarships.ToList<Scholarship>();
            }

            List<ScholarshipBDO> sBDOList = new List<ScholarshipBDO>();
            foreach (Scholarship s in sList)
            {
                ScholarshipBDO sBDO = new ScholarshipBDO();
                ConvertScholarshipToScholarshipBDO(s, sBDO);
                sBDOList.Add(sBDO);
            }
            return sBDOList;
        }

        public Boolean CreateScholarship(ref ScholarshipBDO sBDO, ref string message)
        {
            message = "Scholarship Added Successfully";
            bool ret = true;

            Scholarship s = new Scholarship();
            ConvertScholarshipBDOToScholarship(sBDO, s);
            using (var DCEnt = new DCFIEntities())
            {
                DCEnt.Scholarships.Add(s);
                DCEnt.Entry(s).State = System.Data.Entity.EntityState.Added;
                int num = DCEnt.SaveChanges();
                sBDO.ScholarshipCode = s.ScholarshipCode;

                if (num != 1)
                {
                    ret = false;
                    message = "Adding of Scholarship failed";
                }
            }
            return ret;
        }

        public Boolean AddScholarshipDiscounts(List<ScholarshipDiscountBDO> discounts, string scholarshipCode, ref string message)
        {

            message = "Scholarship Discounts Added Successfully";
            Boolean ret = true;

            foreach (ScholarshipDiscountBDO d in discounts)
            {
                ScholarshipDiscount sd = new ScholarshipDiscount();
                ConvertScholarshipDiscountBDOToScholarshipDiscount(d, sd, scholarshipCode);
                using (var DCEnt = new DCFIEntities())
                {
                    DCEnt.ScholarshipDiscounts.Attach(sd);
                    int num = DCEnt.SaveChanges();
                    if (num != 1)
                        ret = false;
                }
            }
            return ret;
        }

        public Boolean AddScholarshipDiscount(ScholarshipDiscountBDO discount, string scholarshipCode, ref string message)
        {
            message = "Scholarship Discount Added Successfully";
            Boolean ret = true;

            ScholarshipDiscount sd = new ScholarshipDiscount();
            ConvertScholarshipDiscountBDOToScholarshipDiscount(discount, sd, scholarshipCode);
            using (var DCEnt = new DCFIEntities())
            {
                DCEnt.ScholarshipDiscounts.Attach(sd);
                DCEnt.Entry(sd).State = System.Data.Entity.EntityState.Added;
                int num = DCEnt.SaveChanges();

                if (num != 1)
                {
                    ret = false;
                    message = "Adding of Scholarship Discount failed";
                }

                return ret;
            }
        }

        public Boolean UpdateScholarship(ref ScholarshipBDO sBDO, ref string message)
        {
            message = "Scholarship updated successfully.";
            Boolean ret = true;
            Scholarship sc = new Scholarship();
            ConvertScholarshipBDOToScholarship(sBDO, sc);
            Scholarship scholarshipInDB = new Scholarship();
            using (var DCEnt = new DCFIEntities())
            {
                var scholarshipCode = sBDO.ScholarshipCode;
                Scholarship sInDB = (from s in DCEnt.Scholarships
                                     where s.ScholarshipCode == scholarshipCode
                                     select s).FirstOrDefault();
                if (sInDB == null)
                {
                    throw new Exception("No Scholarship with ScholarshipCode " + sBDO.ScholarshipCode);
                }

                // 1st Part
                if (scholarshipInDB.ScholarshipDiscounts.Count == 0)
                {
                    foreach (ScholarshipDiscount sd in sc.ScholarshipDiscounts)
                    {
                        scholarshipInDB.ScholarshipDiscounts.Add(sd);
                    }
                }
                else if (scholarshipInDB.ScholarshipDiscounts.Count < sc.ScholarshipDiscounts.Count)
                {
                    //compare 2 lists check the non existing to the other
                    IEnumerable<ScholarshipDiscount> sdToAdd = sc.ScholarshipDiscounts.Except(scholarshipInDB.ScholarshipDiscounts);
                    if (sdToAdd != null)
                    {
                        foreach (ScholarshipDiscount child in sdToAdd)
                        {
                            scholarshipInDB.ScholarshipDiscounts.Add(child);
                        }
                    }

                    IEnumerable<ScholarshipDiscount> sdToRemove = scholarshipInDB.ScholarshipDiscounts.Except(sc.ScholarshipDiscounts);
                    if (sdToRemove != null)
                    {
                        foreach (ScholarshipDiscount child in sdToRemove)
                        {
                            scholarshipInDB.ScholarshipDiscounts.Add(child);
                        }
                    }
                }
                else if (scholarshipInDB.ScholarshipDiscounts.Count > sc.ScholarshipDiscounts.Count)
                {
                    //compare 2 lists check the non existing to the other
                    IEnumerable<ScholarshipDiscount> sdToAdd = sc.ScholarshipDiscounts.Except(scholarshipInDB.ScholarshipDiscounts);
                    if (sdToAdd != null)
                    {
                        foreach (ScholarshipDiscount child in sdToAdd)
                        {
                            scholarshipInDB.ScholarshipDiscounts.Add(child);
                        }
                    }

                    // TBC
                    IEnumerable<ScholarshipDiscount> sdToRemove = scholarshipInDB.ScholarshipDiscounts.Except(sc.ScholarshipDiscounts);
                    if (sdToRemove != null)
                    {
                        foreach (ScholarshipDiscount child in sdToRemove)
                        {
                            scholarshipInDB.ScholarshipDiscounts.Add(child);
                        }
                    }
                }
                else if (scholarshipInDB.ScholarshipDiscounts.Count == sc.ScholarshipDiscounts.Count)
                {
                    //compare 2 lists check the non existing to the other
                    IEnumerable<ScholarshipDiscount> sdToAdd = sc.ScholarshipDiscounts.Except(scholarshipInDB.ScholarshipDiscounts);
                    if (sdToAdd != null)
                    {
                        foreach (ScholarshipDiscount child in sdToAdd)
                        {
                            scholarshipInDB.ScholarshipDiscounts.Add(child);
                        }
                    }

                    IEnumerable<ScholarshipDiscount> sdToRemove = scholarshipInDB.ScholarshipDiscounts.Except(sc.ScholarshipDiscounts);
                    if (sdToRemove != null)
                    {
                        foreach (ScholarshipDiscount child in sdToRemove)
                        {
                            scholarshipInDB.ScholarshipDiscounts.Add(child);
                        }
                    }
                }
            }
            using (var DC = new DCFIEntities())
            {
                scholarshipInDB = sc;

                DC.Entry(scholarshipInDB).State = System.Data.Entity.EntityState.Modified;
                foreach (ScholarshipDiscount sd in scholarshipInDB.ScholarshipDiscounts)
                    DC.Entry(sd).State = sd.ScholarshipDiscountId == 0 ? System.Data.Entity.EntityState.Added : System.Data.Entity.EntityState.Modified;
                int number = DC.SaveChanges();

                if (number > 0)
                {
                    // ret = false;
                    message = "No Scholarship is updated.";
                }
            }

            return ret;

        }



        //    DCEnt.Scholarships.Remove(sInDB);

        //    sInDB.Condition = sBDO.Condition;
        //    sInDB.Deactivated = sBDO.Deactivated;
        //    sInDB.Description = sBDO.Description;
        //    sInDB.Privilege = sBDO.Privilege;
        //    sInDB.ScholarshipCode = sBDO.ScholarshipCode;

        //    DCEnt.Scholarships.Attach(sInDB);
        //    DCEnt.Entry(sInDB).State = System.Data.Entity.EntityState.Modified;
        //    int num = DCEnt.SaveChanges();

        //    if (num != 1)
        //    {
        //        ret = false;
        //        message = "No scholarship is updated.";
        //    }
        //}
        //return ret;


        public Boolean UpdateScholarshipDiscount(ref ScholarshipDiscountBDO sBDO, ref string message)
        {
            message = "Scholarship discount updated successfully.";
            Boolean ret = true;
            using (var DCEnt = new DCFIEntities())
            {
                var scholarshipCode = sBDO.ScholarshipCode;
                ScholarshipDiscount sInDB = (from s in DCEnt.ScholarshipDiscounts
                                             where s.ScholarshipCode == scholarshipCode
                                             select s).FirstOrDefault();
                if (sInDB == null)
                {
                    throw new Exception("No Scholarship discount with ScholarshipCode " + sBDO.ScholarshipCode);
                }
                DCEnt.ScholarshipDiscounts.Remove(sInDB);

                sInDB.FeeCode = sBDO.FeeCode;
                sInDB.Deactivated = sBDO.Deactivated;
                sInDB.Discount = sBDO.Discount;
                sInDB.ScholarshipCode = sBDO.ScholarshipCode;

                DCEnt.ScholarshipDiscounts.Attach(sInDB);
                DCEnt.Entry(sInDB).State = System.Data.Entity.EntityState.Modified;
                int num = DCEnt.SaveChanges();

                if (num != 1)
                {
                    ret = false;
                    message = "No scholarship discount is updated.";
                }
            }
            return ret;

        }

        public List<ScholarshipDiscountBDO> GetAllScholarshipDiscountsFromScholarship(string scholarshipCode)
        {
            List<ScholarshipDiscount> scholarshipDiscounts = null;
            List<ScholarshipDiscountBDO> sbdoList = new List<ScholarshipDiscountBDO>();
            using (var DCEnt = new DCFIEntities())
            {
                scholarshipDiscounts = (from sd in DCEnt.ScholarshipDiscounts
                                        where sd.ScholarshipCode == scholarshipCode
                                        select sd).ToList<ScholarshipDiscount>();
            }
            foreach (ScholarshipDiscount sd in scholarshipDiscounts)
            {
                ScholarshipDiscountBDO scholDisBDO = new ScholarshipDiscountBDO();
                ConvertScholarshipDiscountToScholarshipDiscountBDO(sd, scholDisBDO, scholarshipCode);
                sbdoList.Add(scholDisBDO);
            }
            return sbdoList;
        }

        public List<StudentBDO> GetAllScholarsofScholarship(string scholarshipCode)
        {
            List<Student> scholars = null;
            List<StudentBDO> sbdoList = new List<StudentBDO>();
            using (var DCEnt = new DCFIEntities())
            {
                scholars = (from s in DCEnt.Students
                            where s.ScholarshipCode == scholarshipCode
                            select s).ToList<Student>();

            }
            foreach (Student s in scholars)
            {
                StudentBDO studentBDO = new StudentBDO();
                ConvertStudentToStudentBDO(s, studentBDO);
                sbdoList.Add(studentBDO);
            }
            return sbdoList;
        }

        public List<StudentBDO> GetAllScholars()
        {
            List<Student> scholars = null;
            List<StudentBDO> sbdoList = new List<StudentBDO>();
            using (var DCEnt = new DCFIEntities())
            {
                scholars = (from s in DCEnt.Students
                            select s).ToList<Student>();

            }
            foreach (Student s in scholars)
            {
                StudentBDO studentBDO = new StudentBDO();
                ConvertStudentToStudentBDO(s, studentBDO);
                sbdoList.Add(studentBDO);
            }
            return sbdoList;
        }

        public List<ScholarshipDiscountBDO> GetAllDiscounts(string scholarshipCode)
        {
            List<ScholarshipDiscountBDO> sdList = new List<ScholarshipDiscountBDO>();
            List<ScholarshipDiscount> discounts = new List<ScholarshipDiscount>();
            using (var DCEnt = new DCFIEntities())
            {
                discounts = (from s in DCEnt.ScholarshipDiscounts
                             where s.ScholarshipCode == scholarshipCode
                             select s).ToList<ScholarshipDiscount>();
            }
            foreach (ScholarshipDiscount sd in discounts)
            {
                ScholarshipDiscountBDO sdBDO = new ScholarshipDiscountBDO();
                ConvertScholarshipDiscountToScholarshipDiscountBDO(sd, sdBDO, scholarshipCode);
                sdList.Add(sdBDO);

            }
            return sdList;
        }

        public Boolean DeleteScholarshipDiscount(string sdCode, string scholarshipCode)
        {
            //message = "User Deleted successfully.";
            Boolean ret = true;

            using (var DCEnt = new DCFIEntities())
            {
                ScholarshipDiscount sdInDB = (from sd in DCEnt.ScholarshipDiscounts
                                              where sd.ScholarshipCode == scholarshipCode && sd.ScholarshipFeeCode == sdCode
                                              select sd).FirstOrDefault();

                if (sdInDB == null)
                {
                    throw new Exception("No Scholarship Discount with ID " + sdCode);
                }

                DCEnt.ScholarshipDiscounts.Remove(sdInDB);
                DCEnt.Entry(sdInDB).State = System.Data.Entity.EntityState.Deleted;
                int num = DCEnt.SaveChanges();
                if (num != 1)
                {
                    ret = false;
                    //message = "Deletion of User Failed.";
                }
            }
            return ret;
        }

        private void ConvertScholarshipToScholarshipBDO(Scholarship s, ScholarshipBDO sbdo)
        {
            sbdo.Condition = s.Condition;
            sbdo.Deactivated = s.Deactivated;
            sbdo.Description = s.Description;
            sbdo.Privilege = s.Privilege;
            sbdo.ScholarshipCode = s.ScholarshipCode;
        }

        private void ConvertScholarshipBDOToScholarship(ScholarshipBDO s, Scholarship sbdo)
        {
            sbdo.Condition = s.Condition;
            sbdo.Deactivated = s.Deactivated;
            sbdo.Description = s.Description;
            sbdo.Privilege = s.Privilege;
            sbdo.ScholarshipCode = s.ScholarshipCode;
        }

        private void ConvertStudentToStudentBDO(Student s, StudentBDO sbdo)
        {
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
        }


        private void ConvertStudentBDOToStudent(StudentBDO s, Student sbdo)
        {
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
            sbdo.ScholarshipCode = s.ScholarshipCode;
            sbdo.SchoolLastAttended = s.SchoolLastAttended;
        }

        private void ConvertScholarshipDiscountBDOToScholarshipDiscount(ScholarshipDiscountBDO d, ScholarshipDiscount sd, string scholarshipCode)
        {
            Fee f = new Fee();
            ConvertFeeBDOToFee(d.Fee, f);
            sd.Deactivated = d.Deactivated;
            sd.Discount = d.Discount;
            sd.FeeCode = d.FeeCode;
            sd.ScholarshipFeeCode = d.ScholarshipFeeCode;
            sd.Fee = f;
        }

        private void ConvertScholarshipDiscountToScholarshipDiscountBDO(ScholarshipDiscount d, ScholarshipDiscountBDO sd, string scholarshipCode)
        {
            FeeBDO f = new FeeBDO();
            ConvertFeeToFeeBDO(d.Fee, f);
            sd.Deactivated = d.Deactivated;
            sd.Discount = d.Discount;
            sd.FeeCode = d.FeeCode;
            sd.ScholarshipFeeCode = d.ScholarshipFeeCode;
            sd.Fee = f;
        }
        private void ConvertFeeBDOToFee(FeeBDO fb, Fee f)
        {
            f.Deactivated = fb.Deactivated;
            f.FeeCode = fb.FeeCode;
            f.FeeDescription = fb.FeeDescription;
        }

        private void ConvertFeeToFeeBDO(Fee fb, FeeBDO f)
        {
            f.Deactivated = fb.Deactivated;
            f.FeeCode = fb.FeeCode;
            f.FeeDescription = fb.FeeDescription;
        }
    }
}
