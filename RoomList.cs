using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using yacht_dice_backend.model;

namespace yacht_dice_backend
{
    public static class RoomList
    {
        static private List<Room> data = null; 

        public static List<Room> GetRoomList()
        {
            if(data == null)
            {
                data = new List<Room>();
            }
            return data;
        }

        public static Room add(Room room)
        {
            var roomList = GetRoomList();
            Room a = new Room()
            {
                RoomNum = roomList.Count(),
                RoomTitle = room.RoomTitle,
                MaxPeople = room.MaxPeople
            };
            roomList.Add(a);
            return a;
        }
    }
}
