using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System
{
    public static class StringExtensions
    {
        public static bool IsEmpty(this string str, bool ignoreWhiteSpace = true)
        {
            if (ignoreWhiteSpace)
            {
                return string.IsNullOrWhiteSpace(str);
            }
            else
            {
                return string.IsNullOrEmpty(str);
            }
        }

        public static string Left(this string str)
        {
            if (str.IsEmpty()) return string.Empty;

            return "";
        }


    }
}
