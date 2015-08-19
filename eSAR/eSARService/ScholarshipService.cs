using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eSARLogic;
using eSARBDO;

namespace eSARService
{
    public class ScholarshipService : IScholarshipService
    {
        ScholarshipLogic sLogic = new ScholarshipLogic();
        public bool AddScholarshipDiscount(ref ScholarshipDiscount scholarshipDiscount, string scholarshipCode, ref string message)
        {
            ScholarshipDiscountBDO sdbdo = new ScholarshipDiscountBDO();
            TranslateScholarshipDiscountToScholarshipDiscountBDO(scholarshipDiscount, sdbdo);
            return sLogic.AddScholarshipDiscount(sdbdo, scholarshipCode, ref message);
        }

        public bool CreateScholarship(ref Scholarship scholarship, ref string message)
        {
            ScholarshipBDO sbdo = new ScholarshipBDO();
            TranslateScholarshipToScholarshipBDO(scholarship, sbdo);
            return sLogic.CreateScholarship(ref sbdo, ref message);
        }

        public bool DeleteScholarshipDiscount(string scholarshipFeeCode, string scholarshipCode)
        {
            return sLogic.DeleteScholarshipDiscount(scholarshipFeeCode, scholarshipCode);
        }

        public List<Student> GetAllScholars()
        {
            //List<Student> sList = new List<Student>();
            //foreach (StudentBDO sBDO in sLogic.GetAllScholars())
            //{
            //    Student scholar = new Student();
            //    Tra
            //}
            throw new NotImplementedException();
        }

        public List<Student> GetAllScholarsOfScholarship(string scholarshipCode)
        {
            throw new NotImplementedException();
        }

        // Done
        public List<ScholarshipDiscount> GetAllScholarshipDiscount(string scholarshipCode)
        {
            List<ScholarshipDiscount> sDiscount = new List<ScholarshipDiscount>();
            foreach (ScholarshipDiscountBDO sdbdo in sLogic.GetAllDiscounts(scholarshipCode))
            {
                ScholarshipDiscount sc = new ScholarshipDiscount();
                TranslateScholarshipDiscountToScholarshipDiscountBDO(sc, sdbdo);
                sDiscount.Add(sc);
            }
            return sDiscount;
        }

        // Done
        public List<Scholarship> GetAllScholarships()
        {
            List<Scholarship> slist = new List<Scholarship>();
            foreach (ScholarshipBDO sbdo in sLogic.GetAllScholarships())
            {
                Scholarship s = new Scholarship();
                TranslateScholarshipBDOToScholarship(sbdo, s);
                slist.Add(s);
            }
            return slist;
        }

        // Done
        public bool UpdateScholarship(ref Scholarship scholarship, ref string message)
        {
            ScholarshipBDO sBDO = new ScholarshipBDO();
            TranslateScholarshipToScholarshipBDO(scholarship, sBDO);
            return sLogic.UpdateScholarship(ref sBDO, ref message);
        }

        // Done
        public bool UpdateScholarshipDiscount(ref ScholarshipDiscount scholarshipDiscount, ref string message)
        {
            ScholarshipDiscountBDO sdBDO = new ScholarshipDiscountBDO();
            TranslateScholarshipDiscountToScholarshipDiscountBDO(scholarshipDiscount, sdBDO);
            return sLogic.UpdateScholarshipDiscount(ref sdBDO, ref message);
        }

        private void TranslateScholarshipToScholarshipBDO(Scholarship sc, ScholarshipBDO sbdo)
        {
            sbdo.Condition = sc.Condition;
            sbdo.Deactivated = sc.Deactivated;
            sbdo.Description = sc.Description;
            sbdo.Privilege = sc.Privilege;
            sbdo.ScholarshipCode = sc.ScholarshipCode;

        }

        private void TranslateScholarshipDiscountToScholarshipDiscountBDO(ScholarshipDiscount sc, ScholarshipDiscountBDO sbdo)
        {
            sbdo.Deactivated = sc.Deactivated;
            sbdo.Discount = sc.Discount;
            sbdo.FeeCode = sc.FeeCode;
            sbdo.ScholarshipCode = sc.ScholarshipCode;
            sbdo.ScholarshipFeeCode = sc.ScholarshipFeeCode;
        }

        private void TranslateScholarshipBDOToScholarship(ScholarshipBDO sc, Scholarship sbdo)
        {
            sbdo.Condition = sc.Condition;
            sbdo.Deactivated = sc.Deactivated;
            sbdo.Description = sc.Description;
            sbdo.Privilege = sc.Privilege;
            sbdo.ScholarshipCode = sc.ScholarshipCode;

        }
    }
}
