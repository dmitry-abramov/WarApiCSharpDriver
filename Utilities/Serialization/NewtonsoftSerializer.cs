using Newtonsoft.Json;

namespace WarApi.Utilities.Serialization
{
    public class NewtonsoftSerializer : ISerializer
    {
        public readonly JsonSerializerSettings settings;

        public NewtonsoftSerializer()
        {
            settings = new JsonSerializerSettings();
        }

        public NewtonsoftSerializer(JsonSerializerSettings serializer)
        {
            this.settings = serializer;
        }

        public string Serialize(object obj)
        {
            var serializedString = JsonConvert.SerializeObject(obj, settings);
            return serializedString;
        }

        public object Deserialize(string serializedString)
        {
            var deserializedObject = JsonConvert.DeserializeObject(serializedString, settings);
            return deserializedObject;
        }

        public T Deserialize<T>(string serializedString)
        {
            var deserializedObject = JsonConvert.DeserializeObject<T>(serializedString, settings);
            return deserializedObject;
        }
    }
}
