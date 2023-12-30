using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZNet.Core.ZNet.Security
{
    public interface IAuthorizationService
    {
        Task IsInRole(string roleName);


    }
}
