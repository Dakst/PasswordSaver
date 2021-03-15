using System.IO;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace PasswordSaver
{
    public class JsonConverter<T>
    {
        public string pathToJsonFile { get; set; }

        public JsonConverter() { }
        public JsonConverter(string pathToJsonFile)
        {
            this.pathToJsonFile = pathToJsonFile;
        }
        public T ReadJsonFile(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string jsonString = reader.ReadToEnd();
                if (jsonString != "")
                {
                    var paramClass = JsonSerializer.Deserialize<T>(jsonString);
                    return paramClass;
                }
                else { return default; }

            }
        }
        public async Task WriteJsonFile(string path, T paramClass)
        {
            using (StreamWriter writer = new StreamWriter(path, false, Encoding.Default))
            {
                string jsonString = JsonSerializer.Serialize(paramClass);
                await writer.WriteAsync(jsonString);
            }
        }

    }
}