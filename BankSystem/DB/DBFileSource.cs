using System.IO;
using System.Runtime.Serialization;
using Database;

namespace BankSystem.DB
{
    [DataContract(Name = "DBFileSource")]
    public class DbFileSource : IDbSource
    {
        public DbFileSource(string pPath)
        {
            Path = pPath;
        }

        [DataMember]
        private string Path { get; set; }

        public Stream GetStream()
        {
            return new FileStream(Path, FileMode.Open);
        }
    }
}