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
        List<Room> roomList = RoomList.GetRoomList();
        [HttpGet]
        public IEnumerable<Room> Get()
        {
            return roomList;
        }
        [HttpPost]
        public void Post(Room a)
        {
            RoomList.add(a);
            return;
        }
    }
}
