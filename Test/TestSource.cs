using System.IO;
using Database;

namespace Test
{
    public class TestSource : IDbSource
    {
        private readonly string _path;

        public TestSource(string pPath)
        {
            _path = pPath;
        }

        public Stream GetStream()
        {
            return new FileStream(_path, FileMode.Open);
        }
    }
}