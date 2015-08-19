using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eSARBDO;

namespace eSARDAL
{
    public class CurriculumDAO
    {
        public List<CurriculumBDO> GetAllCurriculums()
        {
            List<Curriculum> currList = new List<Curriculum>();
            using (var DCEnt = new DCFIEntities())
            {
                var allCurr = (DCEnt.Curriculums);
                currList = allCurr.ToList<Curriculum>();
            }

            List<CurriculumBDO> currBDOList = new List<CurriculumBDO>();
            foreach (Curriculum c in currList)
            {
                CurriculumBDO currBDO = new CurriculumBDO();
                ConvertCurriculumToCurriculumBDO(c, currBDO);
                currBDOList.Add(currBDO);
            }
            return currBDOList;
        }


        private void ConvertCurriculumToCurriculumBDO(Curriculum c, CurriculumBDO currBDO)
        {
            currBDO.CurrentCurr = c.CurrentCurr;
            currBDO.CurriculumCode = c.CurriculumCode;
            currBDO.CurriculumSubjects = GetCurriculumSubjects(c.CurriculumCode);
            currBDO.Description = c.Description;
        }

        public List<CurriculumSubjectBDO> GetCurriculumSubjects(string curriculumCode)
        {
            List<CurriculumSubject> csList = new List<CurriculumSubject>();
            List<CurriculumSubjectBDO> csbList = new List<CurriculumSubjectBDO>();
            using (var DCEnt = new DCFIEntities())
            {
                var allCurrSub = (from cSub in DCEnt.CurriculumSubjects
                                  where cSub.CurriculumCode == curriculumCode
                                  select cSub).ToList<CurriculumSubject>();
                csList = allCurrSub;
            }
            csbList = ToCurriculumSubjectBDOList(csList);
            return csbList;
        }

        private List<CurriculumSubjectBDO> ToCurriculumSubjectBDOList(List<CurriculumSubject> csList)
        {
            List<CurriculumSubjectBDO> csbdoList = new List<CurriculumSubjectBDO>();
            foreach (CurriculumSubject cs in csList)
            {
                SubjectDAO sDAO = new SubjectDAO();
                SubjectBDO sbdo = new SubjectBDO();
                CurriculumSubjectBDO csbdo = new CurriculumSubjectBDO();
                csbdo.CurriculumCode = cs.CurriculumCode;
                csbdo.CurrSubCode = cs.CurrSubCode;
                csbdo.Deactivated = cs.Deactivated;
                csbdo.SubjectCode = cs.SubjectCode;
                sbdo = sDAO.GetSubject(cs.SubjectCode);

                csbdo.Sub = sbdo;
                csbdoList.Add(csbdo);
            }
            return csbdoList;
        }

        private void ConvertCurriculumBDOToCurriculum(CurriculumBDO c, Curriculum currBDO)
        {
            currBDO.CurrentCurr = c.CurrentCurr;
            currBDO.CurriculumCode = c.CurriculumCode;
            currBDO.CurriculumSubjects = ToCurriculumSubjectList(c.CurriculumSubjects);
            currBDO.Description = c.Description;
        }

        private ICollection<CurriculumSubject> ToCurriculumSubjectList(List<CurriculumSubjectBDO> csList)
        {
            ICollection<CurriculumSubject> csbdoList = new List<CurriculumSubject>();
            foreach (CurriculumSubjectBDO cs in csList)
            {
                CurriculumSubject csub = new CurriculumSubject();
                csub.CurriculumCode = cs.CurriculumCode;
                csub.CurrSubCode = cs.CurrSubCode;
                csub.Deactivated = cs.Deactivated;
                csub.SubjectCode = cs.SubjectCode;
                csbdoList.Add(csub);
            }
            return csbdoList;
        }

        public Boolean CreateCurriculum(ref CurriculumBDO cbdo, ref string message)
        {
            message = "Curriculum Added Successfully";
            bool ret = true;
            Curriculum cur = new Curriculum();
            ConvertCurriculumBDOToCurriculum(cbdo, cur);
            using (var DCEnt = new DCFIEntities())
            {
                DCEnt.Curriculums.Add(cur);
                DCEnt.Entry(cur).State = System.Data.Entity.EntityState.Added;
                int num = DCEnt.SaveChanges();


                if (num == 0)
                {
                    ret = false;
                    message = "Adding of Curriculum failed";
                }
            }
            return ret;

        }

        public Boolean UpdateCurriculum(ref CurriculumBDO cbdo, ref string message)
        {
            message = "Curriculum updated successfully.";
            Boolean ret = true;
            Curriculum c = new Curriculum();
            ConvertCurriculumBDOToCurriculum(cbdo, c);
            using (var DCEnt = new DCFIEntities())
            {
                var cCode = c.CurriculumCode;
                Curriculum cInDB = (from curri in DCEnt.Curriculums
                                    where curri.CurriculumCode == cCode
                                    select curri).FirstOrDefault();
                if (cInDB == null)
                {
                    throw new Exception("No Curriculum with Code" + c.CurriculumCode);
                }
                DCEnt.Curriculums.Remove(cInDB);
                ConvertCurriculumBDOToCurriculum(cbdo, cInDB);


                DCEnt.Curriculums.Attach(cInDB);
                DCEnt.Entry(cInDB).State = System.Data.Entity.EntityState.Modified;
                int num = DCEnt.SaveChanges();

                if (num == 0)
                {
                    ret = false;
                    message = "No Curriculum is updated.";
                }
            }
            return ret;
        }
    }
}
