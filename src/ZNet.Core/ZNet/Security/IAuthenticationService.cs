﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZNet.Core.ZNet.Security
{
    public interface IAuthenticationService
    {
        Task AuthenticateAsync();
    }
}
