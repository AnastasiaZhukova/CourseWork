using System.IO;

namespace BankSystem.Atm.Utils
{
    public class AtmSource
    {
        public AtmSource(string pPath)
        {
            Path = pPath;
        }

        private string Path { get; }

        public Stream GetStream()
        {
            return new FileStream(Path, FileMode.Open);
        }
    }
}