using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using yacht_dice_backend.model;

namespace yacht_dice_backend.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Room> Get()
        {
            var roomList = RoomList.GetRoomList();
            roomList.Add(new Room()
            {
                RoomNum = roomList.Count(),
                RoomTitle = "hello",
                MaxPeople = 6
            });
            return roomList;
        }
        [HttpPost]
        public 
    }
}
