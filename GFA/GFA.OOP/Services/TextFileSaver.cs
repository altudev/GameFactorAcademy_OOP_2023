using GFA.OOP.Interfaces;

namespace GFA.OOP.Services
{
    public class TextFileSaver:IFileSaver
    {
        public void Save(string filename, string content)
        {
            File.WriteAllText($"C:\\Users\\alper\\Desktop\\{filename}.txt",content);
        }
    }
}
