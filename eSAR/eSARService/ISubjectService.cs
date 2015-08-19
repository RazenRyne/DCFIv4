using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace eSARService
{
    [ServiceContract]
    public interface ISubjectService
    {
        [OperationContract]
        List<Subject> GetAllSubjects();
        [OperationContract]
        List<Subject> GetAllSubjectsOfLearningArea(string learningAreaCode);
        [OperationContract]
        List<Subject> GetAllSubjectsOfGradeLevel(string gradeLevel);
        [OperationContract]
        Subject GetSubject(string subjectCode);

    }

    [DataContract]
    public class Subject
    {
        [DataMember]
        public int SubjectID { get; set; }
        [DataMember]
        public string SubjectCode { get; set; }
        [DataMember]
        public string LearningAreaCode { get; set; }
        [DataMember]
        public string GradeLevel { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public LearningArea LArea { get; set; }
    }
}
