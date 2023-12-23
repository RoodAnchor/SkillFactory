using System.Runtime.Serialization.Formatters.Binary;

namespace Binary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Contact contact = Deserialize<Contact>("Contact.dat");        
        }

        static void Serialize<T>(T obj, String fileName)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();

            using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                binaryFormatter.Serialize(fs, obj);
            }
        }

        static T Deserialize<T>(String filePath)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();

            T obj;

            using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                obj = (T)binaryFormatter.Deserialize(fs);
            }

            return obj;
        }
    }
}