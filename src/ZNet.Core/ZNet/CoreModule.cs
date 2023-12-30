using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZNet.Builder;

namespace ZNet
{
    public class CoreModule : Modules.IocModuleBase
    {
        public CoreModule() { }

        public override string Name => "ZNet.Core";

        protected override void RegisterServices(IZnetBuilder builder)
        {
        }
    }
}
