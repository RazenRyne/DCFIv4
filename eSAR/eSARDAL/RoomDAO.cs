﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eSARBDO;

namespace eSARDAL
{
    public class RoomDAO
    {
        public List<RoomBDO> GetAllRooms() {
            List<Room> roomList = new List<Room>();
            using (var DCEnt = new DCFIEntities())
            {
                var allRooms = (DCEnt.Rooms);
                roomList = allRooms.ToList<Room>();
            }

            List<RoomBDO> roomBDOList = new List<RoomBDO>();
            foreach (Room r in roomList)
            {
                RoomBDO roomBDO = new RoomBDO();
                ConvertRoomToRoomBDO(r, roomBDO);
                roomBDOList.Add(roomBDO);
            }
            return roomBDOList;
        }

        public RoomBDO GetRoom(string roomCode) {
            Room room = null;
            using (var DCEnt = new DCFIEntities())
            {
                room = (from r in DCEnt.Rooms
                        where r.RoomCode == roomCode
                        select r).FirstOrDefault();

            }
            RoomBDO roomBDO = new RoomBDO();
             ConvertRoomToRoomBDO(room,roomBDO);
          
            return roomBDO;
        }

        public Boolean CreateRoom(ref RoomBDO roomBDO, ref string message)
        {
            message = "Room Added Successfully";
            bool ret = true;

            Room room = new Room();
            ConvertRoomBDOToRoom(roomBDO, room);
            using (var DCEnt = new DCFIEntities())
            {
                DCEnt.Rooms.Attach(room);
                DCEnt.Entry(room).State = System.Data.Entity.EntityState.Added;
                int num = DCEnt.SaveChanges();

                if (num != 1)
                {
                    ret = false;
                    message = "Adding of Room failed";
                }

                return ret;
            }
        }

        public Boolean UpdateRoom(ref RoomBDO roomBDO, ref string message)
        {
            message = "Room updated successfully.";
            Boolean ret = true;
            using (var DCEnt = new DCFIEntities())
            {
                var roomCode = roomBDO.RoomCode;
                Room roomInDB = (from r in DCEnt.Rooms
                                 where r.RoomCode == roomCode
                                 select r).FirstOrDefault();
                if (roomInDB == null)
                {
                    throw new Exception("No room with RoomCode " + roomBDO.RoomCode);
                }
                DCEnt.Rooms.Remove(roomInDB);

                roomInDB.BuildingCode = roomBDO.BuildingCode;
                roomInDB.Capacity = roomBDO.Capacity;
                roomInDB.Deactivated = roomBDO.Deactivated;
                roomInDB.Description = roomBDO.Description;
                roomInDB.RoomCode = roomBDO.RoomNumber;
                roomInDB.RoomNumber = roomBDO.RoomNumber;
                roomInDB.RoomId = roomBDO.RoomId;

                DCEnt.Rooms.Attach(roomInDB);
                DCEnt.Entry(roomInDB).State = System.Data.Entity.EntityState.Modified;
                int num = DCEnt.SaveChanges();

                if (num != 1)
                {
                    ret = false;
                    message = "No room is updated.";
                }
            }
            return ret;

        }

        private void ConvertRoomToRoomBDO(Room r, RoomBDO roomBDO) {
            roomBDO.BuildingCode = r.BuildingCode;
            roomBDO.Capacity =(int)r.Capacity;
            roomBDO.Deactivated = r.Deactivated;
            roomBDO.Description = r.Description;
            roomBDO.RoomCode = r.RoomCode;
            roomBDO.RoomNumber = r.RoomNumber;
            roomBDO.RoomId = r.RoomId;
        }

        private void ConvertRoomBDOToRoom(RoomBDO r, Room room)
        {
            room.BuildingCode = r.BuildingCode;
            room.Capacity = r.Capacity;
            room.Deactivated = r.Deactivated;
            room.Description = r.Description;
            room.RoomCode = r.RoomCode;
            room.RoomNumber = r.RoomNumber;
            room.RoomId = r.RoomId;
        }
    }
}
