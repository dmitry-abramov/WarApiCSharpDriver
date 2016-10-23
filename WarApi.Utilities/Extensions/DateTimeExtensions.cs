using System;

namespace WarApi.Utilities.Extensions
{
    public static class DateTimeExtensions
    {
        public static DateTime Epoch = new DateTime(1970, 1, 1);

        public static long ToUnixTime(this DateTime dateTime)
        {
            var delta = dateTime - Epoch;

            return (long)delta.TotalSeconds;
        }

        public static DateTime ToDateTime(this long unixTime)
        {
            return Epoch.AddSeconds(unixTime);
        }
    }
}
