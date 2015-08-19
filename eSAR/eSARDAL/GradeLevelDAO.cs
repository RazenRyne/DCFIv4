using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eSARBDO;

namespace eSARDAL
{
    public class GradeLevelDAO
    {
        public List<GradeLevelBDO> GetAllGradeLevels()
        {
            List<GradeLevel> gList = new List<GradeLevel>();
            using (var DCEnt = new DCFIEntities())
            {
                var allGradeLevels = (from gl in DCEnt.GradeLevels
                                      orderby gl.Description ascending
                                      select gl);
                gList = allGradeLevels.ToList<GradeLevel>();
            }

            List<GradeLevelBDO> gBDOList = new List<GradeLevelBDO>();
            foreach (GradeLevel g in gList)
            {
                GradeLevelBDO gBDO = new GradeLevelBDO();
                ConvertGradeLevelToGradeLevelBDO(g, gBDO);
                gBDOList.Add(gBDO);
            }
            return gBDOList;
        }

        public Boolean CreateGradeLevel(ref GradeLevelBDO gBDO, ref string message)
        {
            message = "Grade Level Added Successfully";
            bool ret = true;

            GradeLevel g = new GradeLevel();
            ConvertGradeLevelBDOToGradeLevel(gBDO, g);
            using (var DCEnt = new DCFIEntities())
            {
                DCEnt.GradeLevels.Attach(g);
                DCEnt.Entry(g).State = System.Data.Entity.EntityState.Added;
                int num = DCEnt.SaveChanges();

                if (num != 1)
                {
                    ret = false;
                    message = "Adding of Grade Level failed";
                }
            }
            return ret;
        }

        public Boolean UpdateGradeLevel(ref GradeLevelBDO gBDO, ref string message)
        {
            message = "Grade Level updated successfully.";
            Boolean ret = true;
            using (var DCEnt = new DCFIEntities())
            {
                var gCode = gBDO.GradeLev;
                GradeLevel gInDB = (from g in DCEnt.GradeLevels
                                    where g.GradeLevel1 == gCode
                                    select g).FirstOrDefault();
                if (gInDB == null)
                {
                    throw new Exception("No Grade Level " + gBDO.GradeLev);
                }
                DCEnt.GradeLevels.Remove(gInDB);
                gInDB.GradeLevel1 = gBDO.GradeLev;
                gInDB.Description = gBDO.Description;

                DCEnt.GradeLevels.Attach(gInDB);
                DCEnt.Entry(gInDB).State = System.Data.Entity.EntityState.Modified;
                int num = DCEnt.SaveChanges();

                if (num != 1)
                {
                    ret = false;
                    message = "No grade level is updated.";
                }
            }
            return ret;

        }

        public List<FeeBDO> GetAllFeesForGradeLevel(string gradeLevel)
        {
            List<Fee> studentFees = null;
            List<FeeBDO> sfbdoList = new List<FeeBDO>();
            using (var DCEnt = new DCFIEntities())
            {
                studentFees = (from sf in DCEnt.Fees
                               where sf.GradeLevel == gradeLevel
                               select sf).ToList<Fee>();

            }
            foreach (Fee s in studentFees)
            {
                FeeBDO sBDO = new FeeBDO();
                ConvertFeeToFeeBDO(s, sBDO);
                sfbdoList.Add(sBDO);
            }
            return sfbdoList;
        }

        private void ConvertGradeLevelToGradeLevelBDO(GradeLevel g, GradeLevelBDO gbdo)
        {
            gbdo.Description = g.Description;
            gbdo.GradeLev = g.GradeLevel1;
        }

        private void ConvertGradeLevelBDOToGradeLevel(GradeLevelBDO gbdo, GradeLevel g)
        {
            g.Description = gbdo.Description;
            g.GradeLevel1 = gbdo.GradeLev;
        }

        private void ConvertFeeToFeeBDO(Fee sf, FeeBDO sfBDO)
        {
            sfBDO.Amount = sf.Amount;
            sfBDO.DateSet = sf.DateSet;
            sfBDO.Deactivated = sf.Deactivated;
            sfBDO.FeeCode = sf.FeeCode;
            sfBDO.GradeLevel = sf.GradeLevel;
            sfBDO.SYImplemented = sf.SYImplemented;
        }
    }
}
