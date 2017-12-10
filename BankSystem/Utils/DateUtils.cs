using System;

namespace BankSystem.Utils
{
    public static class DateUtils
    {
        private const string UserFriendlyFormat = "G";

        public static long GetCurrentTime()
        {
            return DateTime.Now.ToBinary();
        }

        public static string ConvertToUserFriendlyFormat(long time)
        {
            return DateTime.FromBinary(time).ToString(UserFriendlyFormat);
        }
    }
}