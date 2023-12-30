using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZNet.Net.Http.Providers
{
    public interface IHttpProvider
    {
        Task<TResponse> SendAsync<TRequest, TResponse>(TRequest request, object option, CancellationToken cancellationToken);
    }
}
