using System.Collections.Generic;

namespace WarApi.Utilities.Extensions
{
    public static class KeyValuePairExtensions
    {
        public static string GetLikeUriParameter<TKey, TValue>(this KeyValuePair<TKey, TValue> keyValuePair)
        {
            return string.Format("{0}={1}", keyValuePair.Key.ToString(), keyValuePair.Value.ToString());
        }
    }
}
