using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace System
{
    public static class EncodingExtensions
    {
        public static string ToSha1(this string str)
        {
            str = str ?? string.Empty;

            byte[] data = Encoding.UTF8.GetBytes(str);
            using (var sha1 = SHA1.Create())
            {
                byte[] hash = sha1.ComputeHash(data);
                return BitConverter.ToString(hash).ToLower();
            }
        }

        public static string ToSha256(this string str)
        {
            str = str ?? string.Empty;

            byte[] data = Encoding.UTF8.GetBytes(str);
            using (var sha1 = SHA256.Create())
            {
                byte[] hash = sha1.ComputeHash(data);
                return BitConverter.ToString(hash).ToLower();
            }
        }

        public static string ToSha512(this string str)
        {
            str = str ?? string.Empty;

            byte[] data = Encoding.UTF8.GetBytes(str);
            using (var sha1 = SHA512.Create())
            {
                byte[] hash = sha1.ComputeHash(data);
                return BitConverter.ToString(hash).ToLower();
            }
        }

        public static string ToMD5(this string str)
        {
            str = str ?? string.Empty;

            byte[] data = Encoding.UTF8.GetBytes(str);
            using (var sha1 = MD5.Create())
            {
                byte[] hash = sha1.ComputeHash(data);
                return BitConverter.ToString(hash).ToLower();
            }
        }


    }
}
