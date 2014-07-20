using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;

namespace Utilities.Serialization
{
    public class DotNetJsonSerializer : ISerializer
    {
        public string Serialize(object obj)
        {
            throw new System.NotImplementedException();
        }

        public object Deserialize(string serializedString)
        {
            var serializer = new DataContractJsonSerializer(typeof(object));

            var stream = new MemoryStream(Encoding.Default.GetBytes(serializedString));
            var response = (object)serializer.ReadObject(stream);

            return response;
        }

        public T Deserialize<T>(string serializedString)
        {
            var serializer = new DataContractJsonSerializer(typeof(T));

            var stream = new MemoryStream(Encoding.Default.GetBytes(serializedString));
            var response = (T)serializer.ReadObject(stream);

            return response;
        }
    }
}
