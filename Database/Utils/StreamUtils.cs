using System.IO;

namespace Database.Utils
{
    public static class StreamUtils
    {
        public static void CloseStream(Stream pStream)
        {
            pStream?.Close();
        }
    }
}