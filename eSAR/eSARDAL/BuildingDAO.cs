using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eSARBDO;

namespace eSARDAL
{
    public class BuildingDAO
    {
        public List<BuildingBDO> GetAllBuildings() {
            List<Building> bList = new List<Building>();
            using (var DCEnt = new DCFIEntities())
            {
              var allBuildings = (DCEnt.Buildings);
                 bList = allBuildings.ToList<Building>();
            }

            List<BuildingBDO> bBDOList = new List<BuildingBDO>();
            foreach (Building b in bList) {
                BuildingBDO bBDO = new BuildingBDO();
                ConvertBuildingToBuildingBDO(b, bBDO);
                bBDOList.Add(bBDO);
            }
            return bBDOList;
        }


        public Boolean CreateBuilding(ref BuildingBDO buildBDO, ref string message)
        {
            message = "Building Added Successfully";
            bool ret = true;

            Building b = new Building();
            ConvertBuildingBDOToBuilding(buildBDO,b);
            using (var DCEnt = new DCFIEntities())
            {
                DCEnt.Buildings.Add(b);
                DCEnt.Entry(b).State = System.Data.Entity.EntityState.Added;
                int num = DCEnt.SaveChanges();
                buildBDO.BuildingCode = b.BuildingCode;

                if (num != 1)
                {
                    ret = false;
                    message = "Adding of Building failed";
                }
            }
            return ret;
        }

        public Boolean UpdateBuilding(ref BuildingBDO buildBDO, ref string message)
        {
            message = "Building updated successfully.";
            Boolean ret = true;
            Building b = new Building();
            ConvertBuildingBDOToBuilding(buildBDO, b);
            Building buildingInDB = new Building();
            using (var DCEnt = new DCFIEntities())
            {
                var buildingCode = buildBDO.BuildingCode;
                buildingInDB = (from bee in DCEnt.Buildings
                                 where bee.BuildingCode == buildingCode
                                 select bee).FirstOrDefault();
                if (buildingInDB == null)
                {
                    throw new Exception("No Building with BuildingCode " + buildBDO.BuildingCode);
                }

                // 1st Part
                if (buildingInDB.Rooms.Count == 0)
                {
                    foreach (Room rm in b.Rooms)
                    {
                        buildingInDB.Rooms.Add(rm);
                    }
                }
                else if (buildingInDB.Rooms.Count < b.Rooms.Count)
                {
                    //compare 2 lists check the non existing to the other
                    IEnumerable<Room> rmToAdd = b.Rooms.Except(buildingInDB.Rooms);
                    if (rmToAdd != null)
                    {
                        foreach (Room child in rmToAdd)
                        {
                            buildingInDB.Rooms.Add(child);
                        }
                    }

                    IEnumerable<Room> rmToRemove = buildingInDB.Rooms.Except(b.Rooms);
                    if (rmToRemove != null)
                    {
                        foreach (Room child in rmToRemove)
                        {
                            buildingInDB.Rooms.Add(child);
                        }
                    }

                }
                else if (buildingInDB.Rooms.Count > b.Rooms.Count)
                {
                    //compare 2 lists check the non existing to the other
                    IEnumerable<Room> rmToAdd = b.Rooms.Except(buildingInDB.Rooms);
                    if (rmToAdd != null)
                    {
                        foreach (Room child in rmToAdd)
                        {
                            buildingInDB.Rooms.Add(child);
                        }
                    }


                    // TBC
                    IEnumerable<Room> rmToRemove = buildingInDB.Rooms.Except(b.Rooms);
                    if (rmToRemove != null)
                    {
                        foreach (Room child in rmToRemove)
                        {
                            buildingInDB.Rooms.Add(child);
                        }
                    }
                }
                else if (buildingInDB.Rooms.Count == b.Rooms.Count)
                {
                    //compare 2 lists check the non existing to the other
                    IEnumerable<Room> rmToAdd = b.Rooms.Except(buildingInDB.Rooms);
                    if (rmToAdd != null)
                    {
                        foreach (Room child in rmToAdd)
                        {
                            buildingInDB.Rooms.Add(child);
                        }
                    }

                    IEnumerable<Room> rmToRemove = buildingInDB.Rooms.Except(b.Rooms);
                    if (rmToRemove != null)
                    {
                        foreach (Room child in rmToRemove)
                        {
                            buildingInDB.Rooms.Add(child);
                        }
                    }

                }
            }
            using (var DC = new DCFIEntities())
            {
                buildingInDB = b;

                DC.Entry(buildingInDB).State = System.Data.Entity.EntityState.Modified;
                foreach (Room r in buildingInDB.Rooms)
                    DC.Entry(r).State = r.RoomId == 0 ? System.Data.Entity.EntityState.Added : System.Data.Entity.EntityState.Modified;
                int num = DC.SaveChanges();

                if (num > 0)
                {
                  //  ret = false;
                    message = "No building is updated.";
                }
            }
        
            return ret;

        }

        public List<RoomBDO> GetAllRoomsForBuilding(string buildingCode) {
            List<Room> rooms = null;
            List<RoomBDO> rbdoList = new List<RoomBDO>();
            using (var DCEnt = new DCFIEntities())
            {
                rooms = (from r in DCEnt.Rooms
                        where r.BuildingCode== buildingCode
                        select r).ToList<Room>();

            }
            foreach (Room r in rooms) {
                RoomBDO roomBDO = new RoomBDO();
                ConvertRoomToRoomBDO(r, roomBDO);
                rbdoList.Add(roomBDO);
            }
            return rbdoList;
        }

        private void ConvertRoomToRoomBDO(Room r, RoomBDO roomBDO)
        {
            roomBDO.BuildingCode = r.BuildingCode;
            roomBDO.Capacity = (int)r.Capacity;
            roomBDO.Deactivated = r.Deactivated;
            roomBDO.Description = r.Description;
            roomBDO.RoomCode = r.RoomCode;
            roomBDO.RoomNumber = r.RoomNumber;
        }
        

        private void ConvertBuildingToBuildingBDO(Building b, BuildingBDO bdo) {
            
            bdo.BuildingCode = b.BuildingCode;
            bdo.BuildingName = b.BuildingName;
            bdo.Deactivated = b.Deactivated;
            bdo.Description = b.Description;
            //bdo.Rooms = ToRoomBDOList(b.Rooms);
        }

        private List<RoomBDO> ToRoomBDOList(ICollection<Room> rooms) {
            List<RoomBDO> rBDOList = new List<RoomBDO>();
            foreach (Room r in rooms) {
                RoomBDO rbdo = new RoomBDO();
                rbdo.BuildingCode = r.BuildingCode;
                rbdo.Capacity = (int)r.Capacity;
                rbdo.Deactivated = r.Deactivated;
                rbdo.Description = r.Description;
                rbdo.RoomCode = r.RoomCode;
                rbdo.RoomNumber = r.RoomNumber;
                rBDOList.Add(rbdo);
            }
            return rBDOList;
        }

        private void ConvertBuildingBDOToBuilding(BuildingBDO bdo, Building b)
        {
            b.BuildingCode = bdo.BuildingCode;
            b.BuildingName = bdo.BuildingName;
            b.Deactivated = bdo.Deactivated;
            b.Description = bdo.Description;
            b.Rooms =ToRoomList(bdo.Rooms);
        }

        private List<Room> ToRoomList(List<RoomBDO> rooms)
        {
            List<Room> rList = new List<Room>();
            foreach (RoomBDO rbdo in rooms)
            {
                Room r = new Room();
                r.BuildingCode = rbdo.BuildingCode;
                r.Capacity = (int)rbdo.Capacity;
                r.Deactivated = rbdo.Deactivated;
                r.Description = rbdo.Description;
                r.RoomCode = rbdo.RoomCode;
                r.RoomNumber = rbdo.RoomNumber;
                rList.Add(r);
            }
            return rList;
        }
    }
}
