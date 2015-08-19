using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eSARBDO;

namespace eSARDAL
{
    public class SubjectDAO
    {
        public List<SubjectBDO> GetAllSbjects()
        {
            List<Subject> subjectList = new List<Subject>();
            using (var DCEnt = new DCFIEntities())
            {
                var allSubjects = (DCEnt.Subjects);
                subjectList = allSubjects.ToList<Subject>();
            }

            List<SubjectBDO> subjectBDOList = new List<SubjectBDO>();
            foreach (Subject s in subjectList)
            {
                SubjectBDO subjectBDO = new SubjectBDO();
                ConvertSubjectToSubjectBDO(s, subjectBDO);
                subjectBDOList.Add(subjectBDO);
            }
            return subjectBDOList;
        }

        public SubjectBDO GetSubject(string subjectCode)
        {
            SubjectBDO sbdo = new SubjectBDO();
            Subject subj = new Subject();
            using (var DCEnt = new DCFIEntities())
            {
                var sub = (from s in DCEnt.Subjects
                           where s.SubjectCode == subjectCode
                           select s).FirstOrDefault();
                subj = sub;
            }

            ConvertSubjectToSubjectBDO(subj, sbdo);
            return sbdo;
        }

        public Boolean CreateSubject(ref SubjectBDO subjectBDO, ref string message)
        {
            message = "Subject Added Successfully";
            bool ret = true;

            Subject s = new Subject();
            ConvertSubjectBDOToSubject(subjectBDO, s);

            using (var DCEnt = new DCFIEntities())
            {
                DCEnt.Subjects.Attach(s);
                DCEnt.Entry(s).State = System.Data.Entity.EntityState.Added;
                int num = DCEnt.SaveChanges();

                if (num != 1)
                {
                    ret = false;
                    message = "Adding of Subject failed";
                }
            }
            return ret;
        }

        public Boolean UpdateSubject(ref SubjectBDO subjectBDO, ref string message)
        {
            message = "Subject updated successfully.";
            Boolean ret = true;
            using (var DCEnt = new DCFIEntities())
            {
                var subjectCode = subjectBDO.SubjectCode;
                Subject subjectInDB = (from s in DCEnt.Subjects
                                       where s.SubjectCode == subjectCode
                                       select s).FirstOrDefault();
                if (subjectInDB == null)
                {
                    throw new Exception("No Subject with SubjectCode " + subjectBDO.SubjectCode);
                }
                DCEnt.Subjects.Remove(subjectInDB);

                subjectInDB.SubjectID = subjectBDO.SubjectID;
                subjectInDB.Description = subjectBDO.Description;
                subjectInDB.GradeLevel = subjectBDO.GradeLevel;
                subjectInDB.LearningAreaCode = subjectBDO.LearningAreaCode;
                subjectInDB.SubjectCode = subjectBDO.SubjectCode;

                DCEnt.Subjects.Attach(subjectInDB);
                DCEnt.Entry(subjectInDB).State = System.Data.Entity.EntityState.Modified;
                int num = DCEnt.SaveChanges();

                if (num != 1)
                {
                    ret = false;
                    message = "No subject is updated.";
                }
            }
            return ret;

        }

        public List<SubjectBDO> GetSubjectsforLearningArea(string learningAreaCode)
        {
            List<Subject> subjects = null;
            List<SubjectBDO> sbdoList = new List<SubjectBDO>();
            using (var DCEnt = new DCFIEntities())
            {
                subjects = (from s in DCEnt.Subjects
                            where s.LearningAreaCode == learningAreaCode
                            select s).ToList<Subject>();

            }
            foreach (Subject s in subjects)
            {
                SubjectBDO subjBDO = new SubjectBDO();
                ConvertSubjectToSubjectBDO(s, subjBDO);
                sbdoList.Add(subjBDO);
            }
            return sbdoList;
        }

        public List<SubjectBDO> GetSubjectsforGradeLevel(string gradeLevel)
        {
            List<Subject> subjects = null;
            List<SubjectBDO> sbdoList = new List<SubjectBDO>();
            using (var DCEnt = new DCFIEntities())
            {
                subjects = (from s in DCEnt.Subjects
                            where s.GradeLevel == gradeLevel
                            select s).ToList<Subject>();

            }
            foreach (Subject s in subjects)
            {
                SubjectBDO subjBDO = new SubjectBDO();
                ConvertSubjectToSubjectBDO(s, subjBDO);
                sbdoList.Add(subjBDO);
            }
            return sbdoList;
        }


        public void ConvertSubjectToSubjectBDO(Subject s, SubjectBDO sbdo)
        {
            LearningAreaDAO ldao = new LearningAreaDAO();
            LearningAreaBDO la = new LearningAreaBDO();
            sbdo.Description = s.Description;
            sbdo.GradeLevel = s.GradeLevel;
            sbdo.LearningAreaCode = s.LearningAreaCode;
            sbdo.SubjectCode = s.SubjectCode;
            sbdo.SubjectID = s.SubjectID;
            //  ldao.ConvertLearningAreaToLearningAreaBDO(s.LearningArea, la);
            sbdo.LearningArea = la;
        }

        public void ConvertSubjectBDOToSubject(SubjectBDO sbdo, Subject s)
        {
            s.SubjectID = sbdo.SubjectID;
            s.Description = sbdo.Description;
            s.GradeLevel = sbdo.GradeLevel;
            s.LearningAreaCode = sbdo.LearningAreaCode;
            s.SubjectCode = sbdo.SubjectCode;
        }

        public List<Subject> ToSubjectList(List<SubjectBDO> slist)
        {

            List<Subject> sList = new List<Subject>();
            foreach (SubjectBDO sbdo in slist)
            {
                Subject s = new Subject();
                ConvertSubjectBDOToSubject(sbdo, s);
                sList.Add(s);
            }
            return sList;
        }

        public List<SubjectBDO> ToSubjectBDOList(ICollection<Subject> slist)
        {
            List<SubjectBDO> sbdoList = new List<SubjectBDO>();
            foreach (Subject s in slist)
            {
                SubjectBDO sbdo = new SubjectBDO();
                ConvertSubjectToSubjectBDO(s, sbdo);
                sbdoList.Add(sbdo);
            }
            return sbdoList;
        }
    }
}
