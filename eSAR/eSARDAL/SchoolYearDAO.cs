using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eSARBDO;


namespace eSARDAL
{
    public class SchoolYearDAO
    {

        public SchoolYearBDO GetSYBDO(string sy)
        {
            SchoolYearBDO SYbdo = null;
            using (var DCEnt = new DCFIEntities())
            {
                SchoolYear SY = (from u in DCEnt.SchoolYears
                             where u.SY == sy
                             select u).FirstOrDefault();
                if (SY != null)
                {
                    SYbdo = new SchoolYearBDO()
                    {
                        SY = SY.SY,
                        CurrentSY = SY.CurrentSY
                    };
                }
            }
            return SYbdo;
        }

        public SchoolYear GetSY(string schoolYear)
        {
            SchoolYear sy = null;
            using (var DCEnt = new DCFIEntities())
            {
                sy = (from u in DCEnt.SchoolYears
                        where u.SY == schoolYear
                        select u).FirstOrDefault();

            }

            return sy;

        }

        public List<SchoolYearBDO> GetAllSY()
        {
            List<SchoolYear> syList = new List<SchoolYear>();
            using (var DCEnt = new DCFIEntities())
            {
                var allSY = (DCEnt.SchoolYears);
                syList = allSY.ToList<SchoolYear>();
            }

            List<SchoolYearBDO> syBDOList = new List<SchoolYearBDO>();
            foreach (SchoolYear u in syList)
            {
                SchoolYearBDO syBDO = new SchoolYearBDO();
                ConvertSYToSYBDO(u, syBDO);
                syBDOList.Add(syBDO);
            }
            return syBDOList;
        }

        private void ConvertSYToSYBDO(SchoolYear schoolyear, SchoolYearBDO syBDO)
        {
            syBDO.SY = schoolyear.SY;
            syBDO.CurrentSY = schoolyear.CurrentSY;
        }

        public Boolean CreateSY(ref SchoolYearBDO syBDO, ref string message)
        {
            message = "School Year Added Successfully";
            bool ret = true;


            SchoolYear u = new SchoolYear()
            {
                SY = syBDO.SY,
                CurrentSY = syBDO.CurrentSY
            };

            using (var DCEnt = new DCFIEntities())
            {
                DCEnt.SchoolYears.Attach(u);
                DCEnt.Entry(u).State = System.Data.Entity.EntityState.Added;
                int num = DCEnt.SaveChanges();
                syBDO.SY = u.SY;

                if (num != 1)
                {
                    ret = false;
                    message = "Adding of School Year failed";
                }
            }
            return ret;
        }

        public Boolean UpdateSY(ref SchoolYearBDO syBDO, ref string message)
        {
            message = "School Year updated successfully.";
            Boolean ret = true;
            using (var DCEnt = new DCFIEntities())
            {
                var SY = syBDO.SY;
                SchoolYear syInDB = (from u in DCEnt.SchoolYears
                                 where u.SY == SY
                                 select u).FirstOrDefault();
                if (syInDB == null)
                {
                    throw new Exception(syBDO.SY + " doesn't exist");
                }
                DCEnt.SchoolYears.Remove(syInDB);

                syInDB.SY = syBDO.SY;
                syInDB.CurrentSY = syBDO.CurrentSY;

                DCEnt.SchoolYears.Attach(syInDB);
                DCEnt.Entry(syInDB).State = System.Data.Entity.EntityState.Modified;
                int num = DCEnt.SaveChanges();

                if (num != 1)
                {
                    ret = false;
                    message = "No SY is updated.";
                }
            }
            return ret;

        }

        public Boolean DeleteSY(string schoolyear, ref string message)
        {
            message = "SY " + schoolyear + " Deleted successfully.";
            Boolean ret = true;

            using (var DCEnt = new DCFIEntities())
            {
                SchoolYear SYInDB = (from u in DCEnt.SchoolYears
                                 where u.SY == schoolyear
                                 select u).FirstOrDefault();

                if (SYInDB == null)
                {
                    throw new Exception("No SY " + schoolyear + " existed");
                }

                DCEnt.SchoolYears.Remove(SYInDB);
                DCEnt.Entry(SYInDB).State = System.Data.Entity.EntityState.Deleted;
                int num = DCEnt.SaveChanges();
                if (num != 1)
                {
                    ret = false;
                    message = "Deletion of SY Failed.";
                }
            }
            return ret;
        }

    }
}
