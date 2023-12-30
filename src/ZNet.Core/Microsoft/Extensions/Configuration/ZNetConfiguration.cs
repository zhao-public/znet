using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Extensions.Configuration
{
    internal class ZNetConfigurationProvider : IConfigurationProvider
    {
        public IEnumerable<string> GetChildKeys(IEnumerable<string> earlierKeys, string? parentPath)
        {
            throw new NotImplementedException();
        }

        public IChangeToken GetReloadToken()
        {
            throw new NotImplementedException();
        }

        public void Load()
        {
            throw new NotImplementedException();
        }

        public void Set(string key, string? value)
        {
            throw new NotImplementedException();
        }

        public bool TryGet(string key, out string? value)
        {
            throw new NotImplementedException();
        }
    }
}
