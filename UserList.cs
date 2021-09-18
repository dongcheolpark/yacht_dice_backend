using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using yacht_dice_backend.model;

namespace yacht_dice_backend
{
    public static class UserList
    {
        static private List<User> data = null; 

        public static List<User> GetUserList()
        {
            if(data == null)
            {
                data = new List<User>();
            }
            return data;
        }
        public static int add(User user)
        {
            var UserList = GetUserList();
            User a = new User()
            {
                key = UserList.Count(),
                userName = user.userName
            };
            UserList.Add(a);
            return a.key;
        }
    }
}
