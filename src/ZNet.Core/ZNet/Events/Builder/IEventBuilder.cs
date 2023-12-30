using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZNet.Builder;

namespace ZNet.Events.Builder
{
    public interface IEventBuilder<TEvent> 
        where TEvent: class
    {
       
    }

    internal class EventBuilder<TEvent> : IEventBuilder<TEvent>
        where TEvent : class
    {
        readonly IZnetBuilder _builder;

        public EventBuilder(IZnetBuilder builder)
        {
            _builder = builder;
        }

        public void AddValidtor<TValidator>() { }

        public void AddHandler<THandler>() { }

        public void AddHandler<TResult, THandler>() { }
    }
}
