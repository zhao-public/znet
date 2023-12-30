using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZNet.Data
{
    public interface IDatabase
    {
        Task ExecuteAsync(string sql, dynamic args);

        Task<TItem> QuerySingle<TItem>(string sql, dynamic args);

        Task<IEnumerable<TItem>> Query<TItem>(string sql, dynamic args);
    }

    public interface IReadonlyDatabase : IDatabase
    { 
    }

    public interface IDatabase<TDatabaseInstance> : IDatabase
        where TDatabaseInstance : IDatabaseInstance
    {
    }

    public interface IReadonlyDatabase<TDatabaseInstance> : IReadonlyDatabase
        where TDatabaseInstance : IDatabaseInstance
    {
    }
}
