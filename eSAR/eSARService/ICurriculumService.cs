using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace eSARService
{
    [ServiceContract]
    public interface ICurriculumService
    {
        [OperationContract]
        List<GradeLevel> GetAllGradeLevels();
        [OperationContract]
        Boolean UpdateCurriculum(ref Curriculum curriculum, ref string message);
        [OperationContract]
        Boolean CreateCurriculum(ref Curriculum curriculum, ref string message);
        [OperationContract]
        List<Curriculum> GetAllCurriculums();
        [OperationContract]
        List<CurriculumSubject> GetCurriculumSubjects(string curriculumCode);
        [OperationContract]
        List<CurriculumSubject> GetAllSubjectDetails();
        [OperationContract]
        List<CurriculumSubject> GetAllSubjectsOfGradeLevel(string gradeLevel);


    }

    [DataContract]
    public class Curriculum
    {
        List<CurriculumSubject> subjects = new List<CurriculumSubject>();
        [DataMember]
        public string CurriculumCode { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public bool CurrentCurr { get; set; }
        [DataMember]
        public List<CurriculumSubject> CurriculumSubjects
        {
            get { return subjects; }
            set { this.subjects = value; }
        }
    }
    [DataContract]
    public class CurriculumSubject
    {
        [DataMember]
        public string CurrSubCode { get; set; }
        [DataMember]
        public string CurrDescription { get; set; }
        [DataMember]
        public Boolean CurrentCurr { get; set; }
        [DataMember]
        public string CurriculumCode { get; set; }
        [DataMember]
        public bool Deactivated { get; set; }
        [DataMember]
        public Subject Subj { get; set; }
        [DataMember]
        public string SubjectCode { get; set; }
        [DataMember]
        public string GradeLevel { get; set; }
        [DataMember]
        public string SubjectDescription { get; set; }
        [DataMember]
        public string LearningAreaCode { get; set; }
        [DataMember]
        public Nullable<bool> Academic { get; set; }
        [DataMember]
        public Nullable<double> RatePerUnit { get; set; }
        [DataMember]
        public Nullable<double> Units { get; set; }


    }

}
