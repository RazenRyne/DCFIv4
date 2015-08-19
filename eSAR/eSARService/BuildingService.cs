using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eSARLogic;
using eSARBDO;
namespace eSARService
{
    public class BuildingService : IBuildingService
    {
        BuildingLogic blogic = new BuildingLogic();
        public bool CreateBuilding(ref Building building, ref string message)
        {
            BuildingBDO bbdo = new BuildingBDO();
            TranslateBuildingToBuildingBDO(building, bbdo);
            return blogic.CreateBuilding(ref bbdo, ref message);
        }

        public List<Building> GetAllBuildings()
        {
            List<Building> blist = new List<Building>();
            foreach (BuildingBDO bbdo in blogic.GetAllBuildings()) {
                Building b = new Building();
                TranslateBuildingBDOToBuilding(bbdo, b);
                blist.Add(b);
            }
            return blist;
        }

        public List<Room> GetAllRooms(string buildingCode)
        {
            List<Room> rlist = new List<Room>();
            foreach (RoomBDO rbdo in blogic.GetAllRooms(buildingCode)) {
                Room r = new Room();
                TranslateRoomBDOtoRoomDTO(rbdo, r);
                rlist.Add(r);
             }
            return rlist;
        }

        public bool UpdateBuilding(ref Building building, ref string message)
        {
            BuildingBDO bbdo = new BuildingBDO();
            TranslateBuildingToBuildingBDO(building, bbdo);
            return blogic.UpdateBuilding(ref bbdo, ref message);
        }

        public void TranslateBuildingToBuildingBDO(Building b, BuildingBDO bbdo)
        {
            bbdo.BuildingCode = b.BuildingCode;
            bbdo.BuildingName = b.BuildingName;
            bbdo.Deactivated = b.Deactivated;
            bbdo.Description = b.Description;
            bbdo.Rooms = ToRoomBDOList(b.Rooms);

            
        }

        public void TranslateBuildingBDOToBuilding(BuildingBDO b, Building bbdo)
        {
            bbdo.BuildingCode = b.BuildingCode;
            bbdo.BuildingName = b.BuildingName;
            bbdo.Deactivated = b.Deactivated;
            bbdo.Description = b.Description;
            bbdo.Rooms =ToRoomList(b.Rooms);
        }

        public void TranslateRoomBDOtoRoomDTO(RoomBDO room, Room r)
        {
            r.BuildingCode = room.BuildingCode;
            r.Capacity = room.Capacity;
            r.Deactivated = room.Deactivated;
            r.Description = room.Description;
            r.RoomCode = room.RoomCode;
            r.RoomNumber = room.RoomNumber;
        }

        public void TranslateRoomtoRoomBDO(Room room, RoomBDO r)
        {
            r.BuildingCode = room.BuildingCode;
            r.Capacity = room.Capacity;
            r.Deactivated = room.Deactivated;
            r.Description = room.Description;
            r.RoomCode = room.RoomCode;
            r.RoomNumber = room.RoomNumber;
        }

        public List<Room> ToRoomList(List<RoomBDO> rbdo) {
            List<Room> rooms = new List<Room>();
            foreach (RoomBDO rb in rbdo) {
                Room r = new Room();
                TranslateRoomBDOtoRoomDTO(rb, r);
                rooms.Add(r);
               }
            return rooms;
        }

        public List<RoomBDO> ToRoomBDOList(List<Room> rbdo)
        {
            List<RoomBDO> rooms = new List<RoomBDO>();
            foreach (Room rb in rbdo)
            {
                RoomBDO r = new RoomBDO();
                TranslateRoomtoRoomBDO(rb, r);
                rooms.Add(r);
            }
            return rooms;
        }
    }
}
