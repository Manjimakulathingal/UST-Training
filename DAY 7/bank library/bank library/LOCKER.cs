namespace bank_library
{
    public class Locker
    {
        private int _number
        {
            get
            {
                return _number;
            }
            set { _number = value; }
        }
        private string _lockType;
        private string _password;
        private double _amount;
        private DateTime _lastOpened;



        public Locker()
        {

        }

        public Locker(string lockType, string password, int number)
        {
            _number = number;
            _lockType = lockType;
            _password = password;

        }

        public static Locker CreateLocker(string details) { }


        public void AddLockerToBank(string lockType, string password, int number);   

    }
}