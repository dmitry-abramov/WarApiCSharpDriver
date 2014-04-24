using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoTCSharpDriver.Extensions
{
    internal static class DictionaryExtension
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

        public static string GetLikeUriParameters<TKey, TValue>(this IDictionary<TKey, TValue> dictionary)
        {
            return string.Join("&", dictionary.Select(kv => kv.GetLikeUriParameter())); 
        }
    }
}
