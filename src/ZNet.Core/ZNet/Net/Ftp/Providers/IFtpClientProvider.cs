using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZNet.Net.Ftp.Providers
{
    public interface IFtpClientProvider
    {
        Task ConnectAsync();
    }
}
