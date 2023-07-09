using System.Text.Json;
using GFA.OOP.Interfaces;

namespace GFA.OOP.Services
{
    public class JsonFileSaver:IFileSaver
    {
        public void Save(string filename, string content)
        {
            var json = JsonSerializer.Serialize(content);

            File.WriteAllText($"C:\\Users\\alper\\Desktop\\{filename}.json", json);
        }
    }
}
