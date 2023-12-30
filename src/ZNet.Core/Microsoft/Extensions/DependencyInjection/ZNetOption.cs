using Microsoft.Extensions.FileProviders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Extensions.DependencyInjection
{
    public class ZNetOption
    {
        readonly IList<string> _paths;
        readonly string _rootPath;

        internal ZNetOption()
        {
            _paths = new List<string>();
            
            //Microsoft.Extensions.FileProviders.IFileProvider

        }

        public void AddRefPath(string path)
        {
        }

        #region "Properties"

        public IFileProvider RootPath { get; set; }

        #endregion 
    }
}
