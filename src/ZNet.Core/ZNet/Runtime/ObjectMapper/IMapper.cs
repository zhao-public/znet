using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZNet.Builder;

namespace ZNet.Runtime.ObjectMapper
{
    public interface IMapper
    {
        TTarget MapTo<TItem, TTarget>();
    }

    public interface IMapperProvider<TSrc, TDest>
    {
        TDest MapTo(TSrc src);
    }

    public class DefaultTypeMapperProvider<TSrc, TDest> : IMapperProvider<TSrc, TDest>
    {
        readonly Func<TSrc, TDest> _mapto;

        public DefaultTypeMapperProvider(Func<TSrc, TDest> mapto)
        { 
            this._mapto = mapto;
        }

        public TDest MapTo(TSrc src)
        {
            TDest dest = _mapto(src);

            // 

            return dest;
        }
    }

    public static class MapperExtensions
    {


        public static IZnetBuilder AddMapperProfile<TSrc, TDest>(IZnetBuilder builder, Func<TSrc, TDest> mapTo)
        {


            return builder;
        }
    }
}
