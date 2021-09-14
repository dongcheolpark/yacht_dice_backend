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
    public class GetRoomController : ControllerBase
    {
        [HttpGet]
        public Room Get(int RoomNum)
        {
            Room result = null;
            result = RoomList.GetRoomList().Find(room => room.RoomNum == RoomNum);
            Response.Headers.Add("Access-Control-Allow-Origin", "*");
            if (result != null)
            {
                return result;
            }
            return null;

        }
    }
}
