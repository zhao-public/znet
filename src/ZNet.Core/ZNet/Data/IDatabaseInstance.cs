﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZNet.Data
{
    public interface IDatabaseInstance
    {
        IDatabaseConnectionBuilder ConnectionBuilder { get; }
    }
}
