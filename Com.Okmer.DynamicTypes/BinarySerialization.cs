using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Com.Okmer.DynamicTypes
{
    public static class BinarySerialization
    {
        public static void ToFile<T>(T value, string fileName) where T : ISerializable
        {
            IFormatter formatter = new BinaryFormatter();
            using (Stream stream = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                formatter.Serialize(stream, value);
            }
        }

        public static T FromFile<T>(string fileName) where T : ISerializable, new()
        {
            T result = new T();
            IFormatter formatter = new BinaryFormatter();
            using (Stream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                result = (T)formatter.Deserialize(stream);
            }
            return result;
        }
    }
}
