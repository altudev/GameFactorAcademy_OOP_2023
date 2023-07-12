namespace GFA.OOP.Services
{
    public class VirtualLogger:FileLogger
    {
        public VirtualLogger(string filePath) : base(filePath)
        {
        }

        public VirtualLogger(string filePath, string name) : base(filePath, name)
        {
        }

        public override void LogMyVirtual(string message)
        {
            Console.WriteLine(message);

            base.LogMyVirtual(message);
        }
    }
}
