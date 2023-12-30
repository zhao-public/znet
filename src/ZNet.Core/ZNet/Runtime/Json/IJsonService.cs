using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZNet.Runtime.Json
{
    public interface IJsonService
    {
        string To<TVal>(TVal val);
        TVal From<TVal>(string json);
    }
}
