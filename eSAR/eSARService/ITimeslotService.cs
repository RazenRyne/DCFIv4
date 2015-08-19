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
    public interface ITimeslotService
    {
       
        [OperationContract]
        Timeslot GetTimeslot(string timeslotCode);
        [OperationContract]
        Boolean CreateTimeslot(ref Timeslot timeslot, ref string message);
        [OperationContract]
        Boolean UpdateTimeslot(ref Timeslot timeslot, ref string message);
        [OperationContract]
        List<Timeslot> GetAllTimeslots();
        [OperationContract]
        Boolean DeactivateTimeslot(string timeslotCode, ref string message);
        [OperationContract]
        Boolean ActivateTimeslot(string timeslotCode, ref string message);
        [OperationContract]
        Boolean DeleteTimeslot(string timeslotCode, ref string message);
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "eSARService.ContractType".
    [DataContract]
    public class Timeslot
    {      
        [DataMember]
        public string TimeSlotCode { get; set; }
        [DataMember]
        public string TimeStart { get; set; }
        [DataMember]
        public string TimeEnd { get; set; }
        
        [DataMember]
        public string Days { get; set; }
        [DataMember]
        public bool Deactivated { get; set; }
    }
}
