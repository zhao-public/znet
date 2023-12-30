using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZNet.Runtime.ServiceLocator
{
    public interface IServiceFactory
    {
        TService? GetService<TService>();
        IEnumerable<TService> GetServices<TService>();
    }
}
