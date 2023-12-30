using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZNet.Events.Builder;

namespace ZNet.Builder
{
    public static class EventExtensions
    {
        internal static IZnetBuilder AddEventSupport(this IZnetBuilder builder)
        {
            

            return builder;
        }

        public static IEventBuilder<TEvent> AddEvent<TEvent>(this IZnetBuilder builder)
            where TEvent : class
        {
            var eventBuilder = new EventBuilder<TEvent>(builder);
            return eventBuilder;
        }
    }
}
