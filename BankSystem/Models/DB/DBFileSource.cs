using System.IO;
using Database;

namespace BankSystem.Models.DB
{
    internal class DbFileSource : IDbSource
    {
        private readonly string _path;

        public DbFileSource(string pPath)
        {
            _path = pPath;
        }

        public Stream GetStream()
        {
            return new FileStream(_path, FileMode.Open);
        }
    }
}