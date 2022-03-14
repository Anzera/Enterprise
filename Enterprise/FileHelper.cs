using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Enterprise
{
    public class FileHelper<T> where T : new()//T == List<Employee>
    {
        private string _filePath;

        public FileHelper(string filePath)
        {
            _filePath = filePath;
        }

        public void SerializeToFile(T employees)
        {
            var serializer = new XmlSerializer(typeof(T));

            using (var streamWriter = new StreamWriter(_filePath))//using -> dzięki temu słowu zostanie wykonana metoda Dispose(), która zamknie nam strumień
            {
                serializer.Serialize(streamWriter, employees);
                streamWriter.Close();
            }
        }

        public T DeserializeFromFile()
        {
            if (!File.Exists(_filePath))
                return new T();

            var serializer = new XmlSerializer(typeof(T));

            using (var streamReader = new StreamReader(_filePath))
            {
                var employess = (T)serializer.Deserialize(streamReader);
                streamReader.Close();
                return employess;
            }
        }
    }
}
