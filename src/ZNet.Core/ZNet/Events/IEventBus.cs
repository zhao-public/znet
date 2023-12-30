using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZNet.Events
{
    public interface IEventBus
    {
        Task SendAsync<TEvent>(TEvent eventData);

        Task<TEventResult> SendAsync<TEvent, TEventResult>(TEvent eventData);
    }

    public interface IEventHandler<in TEvent>
        where TEvent : class
    {
        Task InvokeAsync(TEvent eventData);
    }

    public interface IEventHandler<in TEvent, TEventResult>
        where TEvent : class
        where TEventResult : class
    { 
        Task<TEventResult> InvokeAsync(TEvent eventData);
    }
}
