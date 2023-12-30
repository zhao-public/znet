using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace System
{
    public static class QueryableExtensions
    {
        public static IQueryable<TItem> WhereIf<TItem>(this IQueryable<TItem> source, Expression<Func<TItem, bool>> predicate)
        {
            return source.Where(predicate);
        }
    }
}
