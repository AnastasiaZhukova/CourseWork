using System.IO;
using System.Runtime.Serialization.Json;

namespace Database
{
    internal class Serializer<T>
    {
        public T Read(Stream pSourceStream)
        {
            var jsonFormatter = new DataContractJsonSerializer(typeof(T));
            using (pSourceStream)
            {
                var readObject = (T) jsonFormatter.ReadObject(pSourceStream);

                return readObject;
            }
        }

        internal void Write(T pObject, Stream pTargetStream)
        {
            var jsonFormatter = new DataContractJsonSerializer(typeof(T));
            using (pTargetStream)
            {
                jsonFormatter.WriteObject(pTargetStream, pObject);
            }
        }
    }
}