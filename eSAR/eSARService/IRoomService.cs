using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace eSARService
{
    [ServiceContract]
    public interface IRoomService
    {
        [OperationContract]
        Boolean UpdateRoom(ref Room room, ref string message);
        [OperationContract]
        Boolean CreateRoom(ref Room room, ref string message);
        [OperationContract]
        List<Room> GetAllRooms();
        
    }

    [DataContract]
    public class Room
    {
        [DataMember]
        public string RoomCode { get; set; }
        [DataMember]
        public string RoomNumber { get; set; }
        [DataMember]
        public string BuildingCode { get; set; }
        [DataMember]
        public int Capacity { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public Boolean Deactivated { get; set; }
        [DataMember]
        public int RoomId { get; set; }
    }
}
