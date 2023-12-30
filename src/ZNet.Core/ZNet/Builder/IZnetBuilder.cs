using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZNet.Runtime.ServiceLocator;

namespace ZNet.Builder
{
    public interface IZnetBuilder
    {
        //void AddService<TService>() where TService : class;
    }

    internal sealed class ZnetBuilder : IZnetBuilder
    {
        readonly IServiceCollection _services;

        public ZnetBuilder(IServiceCollection services)
        {
            _services = services;
        }

        #region "Methods"

        public void AddService<TService, TImplementation>() 
            where TService : class
            where TImplementation : class, TService
        {
            _services.TryAddTransient<TService, TImplementation>();
        }
        public void AddService<TService>(Func<IServiceFactory, TService> func) { }

        public void AddKeyedService<TService, TImplementation>(string key) { }

        public void AddKeyedService<TService>(string key, Func<IServiceFactory, string, TService> func) { }



        #endregion
    }

    public static class ZnetBuilderExtensions
    {
        public static void AddServiceIfNotExists<TService>(IZnetBuilder builder)
        {
        }
    }
}
