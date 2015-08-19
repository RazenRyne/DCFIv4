using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eSARBDO;

namespace eSARDAL
{
    public class TraitDAO
    {
        public List<TraitBDO> GetAllTraits() {       
            List<Trait> tList = new List<Trait>();
            using (var DCEnt = new DCFIEntities())
            {
               var allTraits = (DCEnt.Traits);
                tList = allTraits.ToList<Trait>();
            }

            List<TraitBDO> tBDOList = new List<TraitBDO>();
            foreach (Trait t in tList)
            {
                TraitBDO tBDO = new TraitBDO();
                ConvertTraitToTraitBDO(t, tBDO);
                tBDOList.Add(tBDO);
            }
            return tBDOList;
        }

        public List<TraitBDO> GetAllTraits(string gradeLevel)
        {
            List<Trait> tList = new List<Trait>();
            using (var DCEnt = new DCFIEntities())
            {
                tList = (from t in DCEnt.Traits
                         where t.GradeLevel ==gradeLevel
                         select t).ToList<Trait>();
            }

            List<TraitBDO> tBDOList = new List<TraitBDO>();
            foreach (Trait t in tList)
            {
                TraitBDO tBDO = new TraitBDO();
                ConvertTraitToTraitBDO(t, tBDO);
                tBDOList.Add(tBDO);
            }
            return tBDOList;
        }


        public Boolean CreateTrait(ref TraitBDO tBDO, ref string message)
        {
            message = "Trait Added Successfully";
            bool ret = true;

            Trait t = new Trait();
            ConvertTraitBDOToTrait(tBDO, t);
            using (var DCEnt = new DCFIEntities())
            {
                DCEnt.Traits.Attach(t);
                DCEnt.Entry(t).State = System.Data.Entity.EntityState.Added;
                int num = DCEnt.SaveChanges();

                if (num != 1)
                {
                    ret = false;
                    message = "Adding of Trait failed";
                }
            }
            return ret;
        }

        public Boolean UpdateTrait(ref TraitBDO tBDO, ref string message)
        {
            message = "Trait updated successfully.";
            Boolean ret = true;
            using (var DCEnt = new DCFIEntities())
            {
                var traitCode = tBDO.TraitCode;
                Trait tInDB = (from t in DCEnt.Traits
                                      where t.TraitCode == traitCode
                                      select t).FirstOrDefault();
                if (tInDB == null)
                {
                    throw new Exception("No Trait with TraitCode " + tBDO.TraitCode);
                }
                DCEnt.Traits.Remove(tInDB);

                tInDB.Description = tBDO.Description;
                tInDB.GradeLevel = tBDO.GradeLevel;
                tInDB.TraitCode = tBDO.TraitCode;

                DCEnt.Traits.Attach(tInDB);
                DCEnt.Entry(tInDB).State = System.Data.Entity.EntityState.Modified;
                int num = DCEnt.SaveChanges();

                if (num != 1)
                {
                    ret = false;
                    message = "No trait is updated.";
                }
            }
            return ret;
        }

        private void ConvertTraitToTraitBDO(Trait t, TraitBDO tBDO)
        {
            tBDO.Description = t.Description;
            tBDO.GradeLevel = t.GradeLevel;
            tBDO.TraitCode = t.TraitCode;
        }

        private void ConvertTraitBDOToTrait(TraitBDO t, Trait tBDO)
        {
            tBDO.Description = t.Description;
            tBDO.GradeLevel = t.GradeLevel;
            tBDO.TraitCode = t.TraitCode;
        }
    }
}
