using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ZNet.Net.Http
{
    [AttributeUsage(AttributeTargets.Interface)]
    public class HttpEndpointAttribute : Attribute
    {
        readonly string _endpoint;

        public HttpEndpointAttribute(string endpoint)
        { 
            _endpoint = endpoint;
        }

        public string Endpoint => _endpoint;
    }

    public class HttpGetAttribute : Attribute { }
    public class HttpPostAttribute : Attribute { }
    public class HttpPutAttribute : Attribute { }
    public class HttpDeleteAttribute : Attribute { }

    public class ClientCertificateAttribute: Attribute 
    {
        public ClientCertificateAttribute(string key) 
        {
        }
    }

    public class HttpHeaderAttribute: Attribute
    {
        readonly string _header;
        readonly HeaderStringValues _values;

        public HttpHeaderAttribute(string key, string[] values)
        {
            _header = key;
            //_values = new IReadOnlyCollection<string>(values);
        }
    }
}
