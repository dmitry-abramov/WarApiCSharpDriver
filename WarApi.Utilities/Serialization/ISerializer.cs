namespace WarApi.Utilities.Serialization
{
    public interface ISerializer
    {
        string Serialize(object obj);

        object Deserialize(string serializedString);

        T Deserialize<T>(string serializedString);
    }
}
