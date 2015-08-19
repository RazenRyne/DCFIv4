using eSARBDO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace eSARService
{

    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface ISchoolYearService
    {
        [OperationContract]
        SchoolYear GetSY(string schoolyear);
        [OperationContract]
        Boolean CreateSY(ref SchoolYear schoolyear, ref string message);
        [OperationContract]
        Boolean UpdateSY(ref SchoolYear schoolyear, ref string message);
        [OperationContract]
        List<SchoolYear> GetAllSY();
        [OperationContract]
        Boolean DeleteSY(string schoolyear, ref string message);
    }

    [DataContract]
    public class SchoolYear
    {
        [DataMember]
        public string SY { get; set; }
        [DataMember]
        public bool CurrentSY { get; set; }

    }
}
