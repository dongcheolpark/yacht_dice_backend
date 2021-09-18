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
    public class UsersController : ControllerBase
    {
        List<User> userList = UserList.GetUserList();
        [HttpPost]
        public int Post(User user)
        {
            return UserList.add(user);
        }
    }
}
