using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZNet.Builder;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ZNetExtension
    {
        public static IZnetBuilder AddZNet(this IServiceCollection services, Action<ZNetOption> actions)
        {
            var option = new ZNetOption();
            actions?.Invoke(option);

            IZnetBuilder builder = new ZnetBuilder(services);

            foreach (var module in LoadModules())
            {
                if (module != null)
                {
                    module.Register(builder);
                }
            }

            return builder;
        }

        private static IEnumerable<ZNet.Modules.IocModuleBase> LoadModules()
        {
            yield break;
        }
    }
}
