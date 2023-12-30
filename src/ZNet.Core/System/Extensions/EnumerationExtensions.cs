using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System
{
    public static class EnumerationExtensions
    {
        public static void ForEach<TItem>(this IEnumerable<TItem> list, Action<TItem> action, Predicate<TItem>? when = null)
        {
            if (list != null)
            { 
                foreach (var item in list)
                {
                    if (when == null || when(item))
                    {
                        action?.Invoke(item);
                    }
                }
            }
        }

        public static async Task ForEachAsync<TItem>(this IEnumerable<TItem> list, Func<TItem, Task> actionAsync, 
            Func<TItem, Task<bool>>? whenAsync = null)
        {
            if (list != null)
            {
                foreach(var item in list)
                {
                    if (whenAsync == null || await whenAsync(item))
                    {
                        if (actionAsync != null)
                        {
                            await actionAsync(item);
                        }
                    }
                }
            }
        }

        public static IEnumerable<TTarget> MapTo<TItem, TTarget>(this IEnumerable<TItem> list, Func<TItem, TTarget> to, Predicate<TItem>? when = null)
        {
            if (list != null)
            {
                foreach (var item in list)
                {
                    if (when == null || when(item))
                    {
                        if (to != null)
                        {
                            yield return to(item);
                        }
                    }
                }
            }
        }

        public static async Task<IEnumerable<TTarget>> MapToAsync<TItem, TTarget>(this IEnumerable<TItem> list, 
            Func<TItem, Task<TTarget>> toAsync, 
            Func<TItem, Task<bool>>? whenAsync = null)
        {
            IList<TTarget> result = new List<TTarget>();

            if (list != null)
            {
                foreach (var item in list)
                {
                    if (whenAsync == null || await whenAsync(item))
                    {
                        if (toAsync != null)
                        {
                            result.Add(await toAsync(item));
                        }
                    }
                }
            }

            return result;
        }

        public static IDictionary<TKey, TItem[]> ToDict<TItem, TKey>(this IEnumerable<TItem> list,
            Func<TItem, TKey> getKeyFunc,
            Predicate<TItem>? when = null)
            where TKey : notnull
        {
            IDictionary<TKey, TItem[]> dict = new Dictionary<TKey, TItem[]>();

            if (list != null)
            {
                foreach(var item in list)
                {
                    if (when == null || when(item))
                    {
                        if (getKeyFunc != null)
                        {
                            TKey key = getKeyFunc(item);
                            if (dict.ContainsKey(key))
                            {
                                IList<TItem> items = new List<TItem>(dict[key]);
                                items.Add(item);

                                dict[key] = items.ToArray();
                            }
                            else
                            {
                                dict.Add(key, new[] { item });
                            }
                        }
                    }
                }
            }

            return dict;
        }

        public static IEnumerable<TItem> Shuffle<TItem>(this IEnumerable<TItem> list)
        {
            if (list == null) return new TItem[0];

            return list.OrderBy(m => Guid.NewGuid());
        }

        public static bool IsEmpty<TItem>(this IEnumerable<TItem> list)
        {
            if (list == null) return true;

            return !list.Any();
        }
    }
}
