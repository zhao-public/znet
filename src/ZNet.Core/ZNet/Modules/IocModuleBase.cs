using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZNet.Builder;

namespace ZNet.Modules
{
    public interface IIocModule
    {
    }

    public abstract class IocModuleBase : IIocModule
    {
        public abstract string Name { get; }

        protected abstract void RegisterServices(IZnetBuilder builder);

        public virtual IIocModule[] Dependencies => new IIocModule[0]; 
    }
}
