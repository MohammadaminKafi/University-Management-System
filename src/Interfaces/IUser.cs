﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectUltimate.Interfaces
{
    internal interface IUser
    {
        string Username { get; set; }
        string Password { get; set; }
        string Role { get; }
    }
}
