using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZNet.Data
{
    public interface IDatabaseTransaction
    {
        IDatabase Database { get; }

        void Begin();
        void Commit();
        void Rollback();
    }

    public static class DatabaseTransactionExtensions
    {
        public static void Apply(this IDatabaseTransaction trans)
        {
            
        }
    }
}
