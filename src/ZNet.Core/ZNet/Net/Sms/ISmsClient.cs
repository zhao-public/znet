using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZNet.Net.Sms
{
    public interface ISmsClient
    {
        Task SendAsync(string message);
    }
}
