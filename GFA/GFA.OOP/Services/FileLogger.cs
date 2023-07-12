using GFA.OOP.Abstract;

namespace GFA.OOP.Services
{
    public class FileLogger:LoggerBase
    {
        private readonly string _filePath;

        public FileLogger(string filePath)
        {
            _filePath = filePath;
        }

        public FileLogger(string filePath, string name):base(name)
        {
            _filePath =filePath;

            Name = name;
        }


        public override void Log(string message)
        {

            var formattedMessage = $"{message}, {DateTime.Now:dd-MM-yyyy hh:mm:ss} \n";

            base.Log(formattedMessage);

            if (File.Exists(_filePath))
              File.AppendAllText(_filePath, formattedMessage);
            
            else
                File.WriteAllText(_filePath, formattedMessage);
        }

        public virtual void LogMyVirtual(string message)
        {

            var formattedMessage = $"{message}, {DateTime.Now:dd-MM-yyyy hh ss} \n";

            if (File.Exists(_filePath))
                File.AppendAllText(_filePath, formattedMessage);

            else
                File.WriteAllText(_filePath, formattedMessage);
        }

        public void Clear()
        {
            File.WriteAllText(_filePath, string.Empty);
        }
    }
}
