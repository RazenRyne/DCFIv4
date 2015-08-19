using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace eSARService
{
    [ServiceContract]
    public interface ILearningAreaService
    {

        [OperationContract]
        Boolean UpdateLearningArea(ref LearningArea learningArea, ref string message);
        [OperationContract]
        Boolean CreateLearningArea(ref LearningArea learningArea, ref string message);
        [OperationContract]
        List<LearningArea> GetAllLearningAreas();
        [OperationContract]
        List<Subject> GetAllSubjects(string learningAreaCode);
        [OperationContract]
        LearningArea GetLearningArea(string learningAreaCode);
    }

    [DataContract]
    public class LearningArea
    {
        List<Subject> subjects = new List<Subject>();
        [DataMember]
        public string LearningAreaCode { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public Nullable<double> Units { get; set; }
        [DataMember]
        public Nullable<bool> Academic { get; set; }
        [DataMember]
        public Nullable<double> RatePerUnit { get; set; }
        [DataMember]
        public List<Subject> Subjects
        {
            get { return subjects; }
            set { this.subjects = value; }
        }
    }


}