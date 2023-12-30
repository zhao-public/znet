using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ZNet.Runtime.Crypto.Providers
{
    public interface ICryptoProvider
    {
    }

    public class AesCryptoProvider : ICryptoProvider
    {
        readonly string Key = "";
        readonly string IV = "";

        public string Encrypt(string data)
        {
            byte[] input = new byte[0];
            byte[] key = new byte[0];
            byte[] iv = new byte[0];

            using (SymmetricAlgorithm aes2 = System.Security.Cryptography.Aes.Create())
            {
                
            }


            return "";
        }


    }

    public class RsaCryptoProvider
    {
    }
}
