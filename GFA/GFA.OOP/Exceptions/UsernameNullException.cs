namespace GFA.OOP.Exceptions
{
    public class UsernameNullException:Exception
    {
        public string GameName { get; set; }

        public UsernameNullException(string gameName, string message):base(message)
        {
            GameName = gameName;
        }

        public UsernameNullException(string message):base(message)
        {
            
        }

        public UsernameNullException()
        {
            
        }
    }
}
