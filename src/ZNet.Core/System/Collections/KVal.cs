using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Collections
{
    public class KeyVal<TKey, TValue>
        where TKey : notnull
    {
        public readonly TKey Key;
        public readonly TValue Value;

        public KeyVal(TKey key, TValue val)
        { 
            Key = key;
            Value = val;
        }
    }

    public static class KeyValExtensions
    {
        
    }
}
