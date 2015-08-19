using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eSARBDO;

namespace eSARDAL
{
    public class GradeSectionDAO
    {
        public List<GradeSectionBDO> GetAllGradeSections()
        {
            List<GradeSection> gsList = new List<GradeSection>();
            using (var DCEnt = new DCFIEntities())
            {
                var allGradeSections = (DCEnt.GradeSections);
                gsList = allGradeSections.ToList<GradeSection>();
            }

            List<GradeSectionBDO> gsBDOList = new List<GradeSectionBDO>();
            foreach (GradeSection gs in gsList)
            {
                GradeSectionBDO gsBDO = new GradeSectionBDO();
                ConvertGradeSectionToGradeSectionBDO(gs, gsBDO);
                gsBDOList.Add(gsBDO);
            }
            return gsBDOList;
        }

        public Boolean CreateGradeSection(ref GradeSectionBDO gsBDO, ref string message)
        {
            message = "Grade Section Added Successfully";
            bool ret = true;

            GradeSection gs = new GradeSection();
            ConvertGradeSectionBDOToGradeSection(gsBDO, gs);
            using (var DCEnt = new DCFIEntities())
            {
                DCEnt.GradeSections.Attach(gs);
                DCEnt.Entry(gs).State = System.Data.Entity.EntityState.Added;
                int num = DCEnt.SaveChanges();

                if (num != 1)
                {
                    ret = false;
                    message = "Adding of Grade Section failed";
                }
            }
            return ret;
        }

        public Boolean UpdateGradeSection(ref GradeSectionBDO gsBDO, ref string message)
        {
            message = "Grade Section updated successfully.";
            Boolean ret = true;
            using (var DCEnt = new DCFIEntities())
            {
                var gsCode = gsBDO.GradeSectionCode;
                   GradeSection gsInDB = (from gs in DCEnt.GradeSections
                                      where gs.GradeSectionCode== gsCode
                                      select gs).FirstOrDefault();
                if (gsInDB == null)
                {
                    throw new Exception("No Grade Section with Grade Section Code " + gsBDO.GradeSectionCode);
                }
                DCEnt.GradeSections.Remove(gsInDB);

                gsInDB.Deactivated = gsBDO.Deactivated;
                gsInDB.GradeLevel = gsBDO.GradeLevel;
                gsInDB.GradeSectionCode = gsBDO.GradeSectionCode;
                gsInDB.HomeRoomNumber = gsBDO.HomeRoomNumber;
                gsInDB.HomeRoomTeacherId = gsBDO.HomeRoomTeacherId;
                gsInDB.Section = gsBDO.Section;
                gsInDB.SY = gsBDO.SY;

                DCEnt.GradeSections.Attach(gsInDB);
                DCEnt.Entry(gsInDB).State = System.Data.Entity.EntityState.Modified;
                int num = DCEnt.SaveChanges();

                if (num != 1)
                {
                    ret = false;
                    message = "No grade section is updated.";
                }
            }
            return ret;

        }

        private void ConvertGradeSectionToGradeSectionBDO(GradeSection gs, GradeSectionBDO gsBDO) {
            gsBDO.Deactivated = gs.Deactivated;
            gsBDO.GradeLevel = gs.GradeLevel;
            gsBDO.GradeSectionCode = gs.GradeSectionCode;
            gsBDO.HomeRoomNumber = gs.HomeRoomNumber;
            gsBDO.HomeRoomTeacherId = gs.HomeRoomTeacherId;
            gsBDO.Section = gs.Section;
            gsBDO.SY = gs.SY;
            
        }

        private void ConvertGradeSectionBDOToGradeSection(GradeSectionBDO gsBDO, GradeSection gs) {
            gs.Deactivated = gsBDO.Deactivated;
            gs.GradeLevel = gsBDO.GradeLevel;
            gs.GradeSectionCode = gsBDO.GradeSectionCode;
            gs.HomeRoomNumber = gsBDO.HomeRoomNumber;
            gs.HomeRoomTeacherId = gsBDO.HomeRoomTeacherId;
            gs.Section = gsBDO.Section;
            gs.SY = gsBDO.SY;
        }

    }
}
