using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZNet.Runtime.Proxy
{
    public class ProxyFactory
    {
        public TProxy? CreateProxy<TProxy>()
            where TProxy : class
        {

            return default(TProxy);
        }
    }
}
