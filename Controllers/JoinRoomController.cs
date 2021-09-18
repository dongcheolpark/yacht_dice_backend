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
    public class JoinRoomController : ControllerBase
    {
        List<Room> roomList = RoomList.GetRoomList();
        [HttpPost]
        public void Post(User user,int roomId)
        {
            Room room = roomList.Find(a => a.RoomNum == roomId);
            room.userLists.Add(user);    
        }
    }
}
