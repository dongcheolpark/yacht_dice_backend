﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace yacht_dice_backend.model
{
    public class User
    {
        [Key]
        public int key { get; set; }
        public string userName { get; set; }
    }
}
