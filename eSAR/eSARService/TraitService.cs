using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eSARLogic;
using eSARBDO;

namespace eSARService
{
    public class TraitService : ITraitService
    {
        TraitLogic tlogic = new TraitLogic();        
        public bool CreateTrait(ref Trait trait, ref string message)
        {
            TraitBDO tbdo = new TraitBDO();
            TranslateTraitToTraitBDO(trait, tbdo);
            return tlogic.CreateTrait(ref tbdo, ref message);
        }

        public void TranslateTraitToTraitBDO(Trait trait, TraitBDO tbdo) {
            tbdo.Description = trait.Description;
            tbdo.GradeLevel = trait.GradeLevel;
            tbdo.TraitCode = trait.TraitCode;
        }
        public void TranslateTraitBDOToTrait(TraitBDO tbdo, Trait t) {
            t.Description = tbdo.Description;
            t.GradeLevel = tbdo.GradeLevel;
            t.TraitCode = tbdo.TraitCode;
        }
        public List<Trait> GetAllTraits()
        {
            List<Trait> tList = new List<Trait>();
            tList = ToTraitList(tlogic.GetAllTraits());
            return tList;
        }

        public List<Trait> ToTraitList(List<TraitBDO> tbList) {
            List<Trait> tList = new List<Trait>();
            foreach (TraitBDO tbdo in tbList) {
                Trait t = new Trait();
                TranslateTraitBDOToTrait(tbdo, t);
                tList.Add(t);
            }
            return tList;
        }

        public List<TraitBDO> ToTraitBDOList(List<Trait> tbList)
        {
            List<TraitBDO> tList = new List<TraitBDO>();
            foreach (Trait t in tbList)
            {
                TraitBDO tb = new TraitBDO();
                TranslateTraitToTraitBDO(t, tb);
                tList.Add(tb);
            }
            return tList;
        }

        public List<Trait> GetAllTraitsOfGradeLevel(string gradeLevel)
        {
            List<Trait> tList = new List<Trait>();
            tList=ToTraitList(tlogic.GetAllTraits(gradeLevel));
            return tList;
        }

        public bool UpdateTrait(ref Trait trait, ref string message)
        {
            TraitBDO tbdo = new TraitBDO();
            TranslateTraitToTraitBDO(trait, tbdo);
            return tlogic.UpdateTrait(ref tbdo, ref message);
        }
    }
}
