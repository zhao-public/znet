using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ZNet.Net.Http
{
    public class HttpEndpointOption
    {
        public string? Name { get; private set; }

        public X509Certificate2? ClientCertificate { get; set; }


    }
}
