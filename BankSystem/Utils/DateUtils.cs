using System;

namespace BankSystem.Utils
{
    public static class DateUtils
    {
        public static string getCurrentDate()
        {
            return DateTime.Today.ToShortDateString();
        }

        public static long getCurrentTime()
        {
            return DateTime.Now.ToBinary();
        }
    }
}