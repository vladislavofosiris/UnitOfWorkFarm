﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public interface IDeletable
    {
        bool IsDelete { get; set; }
    }
}
