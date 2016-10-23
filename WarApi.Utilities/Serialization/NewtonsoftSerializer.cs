using Newtonsoft.Json;

namespace WarApi.Utilities.Serialization
{
    public class NewtonsoftSerializer : ISerializer
    {
        public readonly JsonSerializerSettings Settings;

        public NewtonsoftSerializer()
        {
            Settings = new JsonSerializerSettings();
            Settings.Converters.Add(new DateTimeJsonConverter());
            Settings.Converters.Add(new LanguageJsonConverter());
            Settings.Converters.Add(new RatingTypeJsonConverter());
        }

        public string Serialize(object obj)
        {
            var serializedString = JsonConvert.SerializeObject(obj, Settings);
            return serializedString;
        }

        public object Deserialize(string serializedString)
        {
            var deserializedObject = JsonConvert.DeserializeObject(serializedString, Settings);
            return deserializedObject;
        }

        public T Deserialize<T>(string serializedString)
        {
            var deserializedObject = JsonConvert.DeserializeObject<T>(serializedString, Settings);
            return deserializedObject;
        }
    }
}
