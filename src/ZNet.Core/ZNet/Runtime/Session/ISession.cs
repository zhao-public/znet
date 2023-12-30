using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZNet.Runtime.Session
{
    public interface ISession
    {
        string SessionToken { get; }
    }
}
