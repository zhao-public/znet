using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZNet.Runtime.Jobs
{
    public interface IJob
    {
        string Name { get; }

        Task ExecuteAsync();
    }
}
