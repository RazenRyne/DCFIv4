using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eSARBDO;

namespace eSARDAL
{
    public class LearningAreaDAO
    {

        SubjectDAO sDAO = new SubjectDAO();
        GradeLevelDAO gDAO = new GradeLevelDAO();

        public List<GradeLevelBDO> GetAllGradeLevels()
        {
            return gDAO.GetAllGradeLevels();
        }


        public List<LearningAreaBDO> GetLearningAreas()
        {
            List<LearningArea> laList = new List<LearningArea>();
            using (var DCEnt = new DCFIEntities())
            {
                var allLA = (DCEnt.LearningAreas);
                laList = allLA.ToList<LearningArea>();

            }

            List<LearningAreaBDO> laBDOList = new List<LearningAreaBDO>();
            foreach (LearningArea l in laList)
            {
                LearningAreaBDO laBDO = new LearningAreaBDO();
                ConvertLearningAreaToLearningAreaBDO(l, laBDO);
                laBDOList.Add(laBDO);
            }
            return laBDOList;
        }


        public LearningAreaBDO GetLearningArea(string learningAreaCode)
        {
            LearningArea l = new LearningArea();
            using (var DCEnt = new DCFIEntities())
            {
                var lA = (from learn in DCEnt.LearningAreas
                          where learn.LearningAreaCode == learningAreaCode
                          select learn).FirstOrDefault();

                l = lA;
            }

            LearningAreaBDO laBDO = new LearningAreaBDO();
            ConvertLearningAreaToLearningAreaBDO(l, laBDO);

            return laBDO;
        }

        public Boolean CreateLearningArea(ref LearningAreaBDO laBDO, ref string message)
        {
            message = "Learning Area Added Successfully";
            bool ret = true;

            LearningArea la = new LearningArea();
            ConvertLearningAreaBDOToLearningArea(laBDO, la);
            using (var DCEnt = new DCFIEntities())
            {
                DCEnt.LearningAreas.Add(la);
                DCEnt.Entry(la).State = System.Data.Entity.EntityState.Added;
                int num = DCEnt.SaveChanges();


                if (num == 0)
                {
                    ret = false;
                    message = "Adding of Learning Area failed";
                }
            }
            return ret;
        }

        public Boolean UpdateLearningArea(ref LearningAreaBDO laBDO, ref string message)
        {
            Boolean ret = true;
            LearningArea l = new LearningArea();
            ConvertLearningAreaBDOToLearningArea(laBDO, l);
            LearningArea laInDB = new LearningArea();
            using (var DCEnt = new DCFIEntities())
            {
                var learningAreaCode = laBDO.LearningAreaCode;
                laInDB = (from la in DCEnt.LearningAreas
                               where la.LearningAreaCode.Equals(learningAreaCode)
                               select la).FirstOrDefault();

                if (laInDB == null)
                {
                    throw new Exception("No Learning Area with Code " + laBDO.LearningAreaCode);
                }

                if (laInDB.Subjects.Count == 0)
                {
                    foreach (Subject s in l.Subjects)
                    {
                        laInDB.Subjects.Add(s);
                    }
                }
                else if (laInDB.Subjects.Count < l.Subjects.Count)
                {
                    //compare 2 lists check the non existing to the other
                    IEnumerable<Subject> sToAdd = l.Subjects.Except(laInDB.Subjects);
                    if (sToAdd != null)
                    {
                        foreach (Subject child in sToAdd)
                        {
                            laInDB.Subjects.Add(child);
                        }
                    }

                    IEnumerable<Subject> sToRemove = laInDB.Subjects.Except(l.Subjects);
                    if (sToRemove != null)
                    {
                        foreach (Subject child in sToRemove)
                        {
                            laInDB.Subjects.Add(child);
                        }
                    }

                }
                else if (laInDB.Subjects.Count > l.Subjects.Count)
                {
                    //compare 2 lists check the non existing to the other
                    IEnumerable<Subject> sToAdd = l.Subjects.Except(laInDB.Subjects);
                    if (sToAdd != null)
                    {
                        foreach (Subject child in sToAdd)
                        {
                            laInDB.Subjects.Add(child);
                        }
                    }

                    IEnumerable<Subject> sToRemove = laInDB.Subjects.Except(l.Subjects);
                    if (sToRemove != null)
                    {
                        foreach (Subject child in sToRemove)
                        {
                            laInDB.Subjects.Add(child);
                        }
                    }
                }
                else if (laInDB.Subjects.Count == l.Subjects.Count)
                {
                    //compare 2 lists check the non existing to the other
                    IEnumerable<Subject> sToAdd = laInDB.Subjects.Except(l.Subjects);
                    IEnumerable<Subject> sToRemove = l.Subjects.Except(laInDB.Subjects);
                    if (sToAdd != null)
                    {
                        foreach (Subject child in sToAdd)
                        {
                            laInDB.Subjects.Add(child);
                        }
                    }

                    if (sToRemove != null)
                    {
                        foreach (Subject child in sToRemove)
                        {
                            laInDB.Subjects.Remove(child);
                        }
                    }

                }
                using (var DC = new DCFIEntities())
                {


                    //   DC.Teachers.Remove(teacherInDB);
                    laInDB = l;

                    foreach (Subject s in laInDB.Subjects)
                        DC.Entry(s).State = s.SubjectID == 0 ? System.Data.Entity.EntityState.Added : System.Data.Entity.EntityState.Modified;

                    DC.Entry(laInDB).State = System.Data.Entity.EntityState.Modified;                  

                     int num = DC.SaveChanges();

                    if (num > 0)
                    {
                        message = "No learning area is updated.";
                    }
                }
            }
            return ret;



        }

        public List<SubjectBDO> GetSubjectsforLearningArea(string learningAreaCode)
        {
            List<SubjectBDO> subjectlist = new List<SubjectBDO>();
            ICollection<Subject> subject;
            using (var DCEnt = new DCFIEntities())
            {
                subject = (from s in DCEnt.Subjects
                           where s.LearningAreaCode.Equals(learningAreaCode)
                               select s).ToList<Subject>();
            }
            subjectlist = ToSubjectBDOList(subject);
            return subjectlist;
        }

        public void ConvertLearningAreaToLearningAreaBDO(LearningArea la, LearningAreaBDO labdo)
        {
            // SubjectDAO sdao = new SubjectDAO();
            labdo.Subjects = GetSubjectsforLearningArea(la.LearningAreaCode);
            labdo.Academic = la.Academic;
            labdo.Description = la.Description;
            labdo.LearningAreaCode = la.LearningAreaCode;
            labdo.Units = la.Units;
            labdo.RatePerUnit = la.RatePerUnit;

        }
        public List<SubjectBDO> ToSubjectBDOList(ICollection<Subject> slist)
        {
            SubjectDAO sd = new SubjectDAO();
            List<SubjectBDO> sbdoList = new List<SubjectBDO>();
            foreach (Subject s in slist)
            {
                SubjectBDO sbdo = new SubjectBDO();
                sd.ConvertSubjectToSubjectBDO(s, sbdo);
                sbdoList.Add(sbdo);
            }
            return sbdoList;
        }

        public ICollection<Subject> ToSubjectList(List<SubjectBDO> slist)
        {
            SubjectDAO sd = new SubjectDAO();
            ICollection<Subject> subjectList = new List<Subject>();
            foreach (SubjectBDO sbdo in slist)
            {
                Subject subject = new Subject();
                sd.ConvertSubjectBDOToSubject(sbdo, subject);
                subjectList.Add(subject);
            }
            return subjectList;
            //SubjectDAO sd = new SubjectDAO();
            //ICollection<Subject> sList = new List<Subject>();
            //foreach (SubjectBDO sbdo in slist)
            //{
            //    Subject s = new Subject();
            //    sd.ConvertSubjectToSubjectBDO(s, sbdo);
            //    sList.Add(s);
            //}
            //return sList;
        }
        public void ConvertLearningAreaBDOToLearningArea(LearningAreaBDO labdo, LearningArea la)
        {
            SubjectDAO sdao = new SubjectDAO();
            la.Academic = labdo.Academic;
            la.Description = labdo.Description;
            la.LearningAreaCode = labdo.LearningAreaCode;
            la.Units = labdo.Units;
            la.RatePerUnit = labdo.RatePerUnit;
            la.Subjects = sdao.ToSubjectList(labdo.Subjects);
        }

    }
}
