using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eSARLogic;
using eSARBDO;
namespace eSARService
{
    public class LearningAreaService : ILearningAreaService
    {
        LearningAreaLogic laLogic = new LearningAreaLogic();
        public bool CreateLearningArea(ref LearningArea learningArea, ref string message)
        {
            LearningAreaBDO lBdo = new LearningAreaBDO();
            TranslateLearningAreaToLearningAreaBDO(learningArea, lBdo);
            return laLogic.CreateLearningArea(ref lBdo, ref message);
        }

        public List<LearningArea> GetAllLearningAreas()
        {
            List<LearningArea> lList = new List<LearningArea>();
            foreach (LearningAreaBDO labdo in laLogic.GetAllLearningAreas())
            {
                LearningArea la = new LearningArea();
                TranslateLearningAreaBDOToLearningArea(labdo, la);
                lList.Add(la);
            }
            return lList;
        }

        public LearningArea GetLearningArea(string learningAreaCode)
        {
            LearningArea la = new LearningArea();

            TranslateLearningAreaBDOToLearningArea(laLogic.GetLearningArea(learningAreaCode), la);

            return la;
        }

        public List<Subject> GetAllSubjects(string learningAreaCode)
        {
            SubjectService ss = new SubjectService();
            List<Subject> sList = new List<Subject>();
            sList = ss.ToSubjectList(laLogic.GetAllSubjects(learningAreaCode));
            return sList;
        }

        public bool UpdateLearningArea(ref LearningArea learningArea, ref string message)
        {
            LearningAreaBDO labdo = new LearningAreaBDO();
            TranslateLearningAreaToLearningAreaBDO(learningArea, labdo);
            return laLogic.UpdateLearningArea(ref labdo, ref message);
        }

        public void TranslateLearningAreaToLearningAreaBDO(LearningArea la, LearningAreaBDO lBdo)
        {
            lBdo.Academic = la.Academic;
            lBdo.Description = la.Description;
            lBdo.LearningAreaCode = la.LearningAreaCode;
            lBdo.RatePerUnit = la.RatePerUnit;
            lBdo.Units = la.Units;
            lBdo.Subjects = ToSubjectBDOList(la.Subjects);
        }

        public List<SubjectBDO> ToSubjectBDOList(List<Subject> sList)
        {
            List<SubjectBDO> slist = new List<SubjectBDO>();
            foreach (Subject s in sList)
            {
                SubjectBDO sbdo = new SubjectBDO();
                sbdo.LearningAreaCode = s.LearningAreaCode;
                sbdo.Description = s.Description;
                sbdo.GradeLevel = s.GradeLevel;
                sbdo.SubjectCode = s.SubjectCode;
                sbdo.SubjectID = s.SubjectID;
                slist.Add(sbdo);
            }
            return slist;
        }

        public void TranslateLearningAreaBDOToLearningArea(LearningAreaBDO la, LearningArea lBdo)
        {
            SubjectService ss = new SubjectService();
            lBdo.Academic = la.Academic;
            lBdo.Description = la.Description;
            lBdo.LearningAreaCode = la.LearningAreaCode;
            lBdo.RatePerUnit = la.RatePerUnit;
            lBdo.Units = la.Units;
            lBdo.Subjects = ss.ToSubjectList(la.Subjects);
        }
          
    }
}
