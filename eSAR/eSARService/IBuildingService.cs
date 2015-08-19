using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace eSARService
{
    [ServiceContract]
    public interface IBuildingService
    {
        [OperationContract]
        Boolean UpdateBuilding(ref Building building, ref string message);
        [OperationContract]
        Boolean CreateBuilding(ref Building building, ref string message);
        [OperationContract]
        List<Building> GetAllBuildings();
        [OperationContract]
        List<Room> GetAllRooms(string buildingCode);
    }

    [DataContract]
    public class Building
    {
        List<Room> roomList = new List<Room>();
        [DataMember]
        public string BuildingCode { get; set; }
        [DataMember]
        public string BuildingName { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public Boolean Deactivated { get; set; }
        [DataMember]
        public List<Room> Rooms
        {
            get { return this.roomList; }
            set { this.roomList = value; }
        }
    }
    
}
