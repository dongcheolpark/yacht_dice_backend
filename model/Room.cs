using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace yacht_dice_backend.model
{
    public class Room
    {
        [Key]
        public int RoomNum { get; set; }
        public String RoomTitle { get; set; }
        public int MaxPeople { get; set; }
    }
}
