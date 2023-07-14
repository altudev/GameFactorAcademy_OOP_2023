namespace GFA.MobileClient.Models
{
    public class DuzIks
    {
        private readonly decimal _duzIsk;

        public DuzIks(int duzIsk)
        {
            _duzIsk = duzIsk;
        }

        public DuzIks(long duzIsk)
        {
            _duzIsk = duzIsk;
        }

        public DuzIks(double duzIsk)
        {
            _duzIsk = (decimal)duzIsk;
        }

        public DuzIks(decimal duzIsk)
        {
            _duzIsk = duzIsk;
        }

        public static implicit operator DuzIks(double number)
        {
            return new DuzIks(number);
        }

        public static explicit operator DuzIks(decimal number)
        {
            return new DuzIks(number);
        }
    }
}
