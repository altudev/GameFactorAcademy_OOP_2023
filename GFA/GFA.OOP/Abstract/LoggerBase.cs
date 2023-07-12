namespace GFA.OOP.Abstract
{
    public abstract class LoggerBase
    {
        public string Name { get; set; }

        public virtual void Log(string message) => Console.WriteLine($"Logger:{Name}, {message}");

        protected LoggerBase(string name)
        {
            Name = name;
        }

        protected LoggerBase()
        {
            
        }
    }
}
