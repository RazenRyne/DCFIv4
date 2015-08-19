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
    public interface IGradeLevelService
    {
        [OperationContract]
        List<GradeLevel> GetAllGradeLevels();
    }

    [DataContract]
    public class GradeLevel
    {
        List<Trait> traits = new List<Trait>();
        List<Fee> studFees = new List<Fee>();
        [DataMember]
        public string GradeLev { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public List<Fee> StudentFees
        {
            get { return studFees; }
            set { studFees = value; }
        }
        [DataMember]
        public List<Trait> Traits
        {
            get { return this.traits; }
            set { this.traits = value; }
        }
    }
}
