﻿using System.IO;

namespace BankSystem.Atm.Utils
{
    public static class StreamUtils
    {
        public static void CloseStream(Stream pStream)
        {
            pStream?.Close();
        }
    }
}