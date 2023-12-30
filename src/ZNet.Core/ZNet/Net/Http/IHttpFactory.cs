using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZNet.Builder;

namespace ZNet.Net.Http
{
    public interface IHttpFactory
    {
        TClient GetClient<TClient>() where TClient : class;
    }

    public static class HttpExtensions
    {
        public static IZnetBuilder AddHttpEndpoint(this IZnetBuilder builder, string name, Action<HttpEndpointOption> options)
        {
            return builder;
        }
    }
}
