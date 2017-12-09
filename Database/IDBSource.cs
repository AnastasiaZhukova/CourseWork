using System.IO;

namespace Database
{
    public interface IDbSource
    {
        Stream GetStream();
    }
}