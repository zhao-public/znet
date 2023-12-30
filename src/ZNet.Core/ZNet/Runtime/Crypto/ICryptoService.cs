using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZNet.Runtime.Crypto
{
    public interface ICryptoServiceFactory
    {
        ICryptoService GetService(string key);
    }

    public interface ICryptoService : IDisposable, IAsyncDisposable
    {
        string Encrypt(string data);
        string Decrypt(string data);
    }
}
