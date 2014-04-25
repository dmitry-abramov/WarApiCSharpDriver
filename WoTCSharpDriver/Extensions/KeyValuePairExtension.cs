using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoTCSharpDriver.Extensions
{
    internal static class KeyValuePairExtension
    {
        public static string GetLikeUriParameter<TKey, TValue>(this KeyValuePair<TKey, TValue> keyValuePair)
        {
            return string.Format("{0}=\"{1}\"", keyValuePair.Key.ToString(), keyValuePair.Value.ToString());
        }
    }
}
