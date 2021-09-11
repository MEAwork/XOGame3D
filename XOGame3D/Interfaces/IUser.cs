﻿using System;
using System.Collections.Generic;
using System.Text;
using XOGame3D.Enum;

namespace XOGame3D.Interfaces
{
    public interface IUser
    {
        string Name { get; set; }

        States State { get; set; }
    }
}
