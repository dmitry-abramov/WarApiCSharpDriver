using System.Collections.Generic;
using System.Linq;

namespace WarApi.Utilities.Extensions
{
    public static class DictionaryExtensions
    {
        public static void AddOrUpdate<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key, TValue value)
        {
            if (dictionary.ContainsKey(key))
            {
                dictionary.Remove(key);
                dictionary.Add(key, value);
            }
            else
            {
                dictionary.Add(key, value);
            }
        }

        public static string ToUriParametersString<TKey, TValue>(this IDictionary<TKey, TValue> dictionary)
        {
            return string.Join("&", dictionary.Select(kv => kv.GetLikeUriParameter())); 
        }
    }
}
