using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eSARBDO;
using eSARDAL;

namespace eSARLogic
{
    public class ScholarshipLogic
    {
        ScholarshipDAO sDAO = new ScholarshipDAO();
        public List<ScholarshipBDO> GetAllScholarships()
        {
            List<ScholarshipBDO> scholBDO = new List<ScholarshipBDO>();
            foreach (ScholarshipBDO s in sDAO.GetAllScholarships())
            {
                s.ScholarshipDiscounts = GetAllScholarshipDiscounts(s.ScholarshipCode);

                scholBDO.Add(s);
            }
            return scholBDO;
        }

        public List<ScholarshipDiscountBDO> GetAllScholarshipDiscounts(string scholarshipCode)
        {
            return sDAO.GetAllScholarshipDiscountsFromScholarship(scholarshipCode);
        }


        public List<StudentBDO> GetAllScholars()
        {
            return sDAO.GetAllScholars();
        }

        public List<StudentBDO> GetAllScholarsofScholarship(string scholarshipCode)
        {
            return sDAO.GetAllScholarsofScholarship(scholarshipCode);
        }

        public List<ScholarshipDiscountBDO> GetAllDiscounts(string scholarshipCode)
        {
            return sDAO.GetAllDiscounts(scholarshipCode);
        }

        public Boolean AddScholarshipDiscount(ScholarshipDiscountBDO sdBDO, string scholarshipCode, ref string message)
        {
            return sDAO.AddScholarshipDiscount(sdBDO, scholarshipCode, ref message);
        }

        public Boolean CreateScholarship(ref ScholarshipBDO sbdo, ref string message)
        {
            return sDAO.CreateScholarship(ref sbdo, ref message);
        }

        public Boolean UpdateScholarship(ref ScholarshipBDO sbdo, ref string message)
        {
            return sDAO.UpdateScholarship(ref sbdo, ref message);
        }

        public Boolean UpdateScholarshipDiscount(ref ScholarshipDiscountBDO sdBDO, ref string message)
        {
            return sDAO.UpdateScholarshipDiscount(ref sdBDO, ref message);
        }

        public Boolean DeleteScholarshipDiscount(string sdbdoCode, string scholarshipCode)
        {
            return sDAO.DeleteScholarshipDiscount(sdbdoCode, scholarshipCode);
        }

    }
}
