using System;

namespace account
{
    internal class Account
    {
        public int Id;
        public string Name;
        private decimal _balance;


        public decimal Balance
        {
            get
            {
                return _balance;
            }
        }
        private string _name
        {
            set
            {
                if (value.Length < 15)
                    throw new ApplicationException("name too short");
            }
        }
      
    }

        public Account(int id, string nam, decimal balance)
        {
            Id = id;
            Name = name;
            _balance = balance;
            Console.WriteLine("acc created ");
        }

        public Account()
        {
        }

        public void display()
        {
            Console.WriteLine("id is" + Id);
            Console.WriteLine("name is" + Name);
            Console.WriteLine("balance is" + _balance);
        }
        public void deposit(decimal amount) 
        {
            _balance += amount;
        }
        public void Withdrawal(decimal amount)
        {
           if(_balance - amount < 100)
            {
                Console.WriteLine("LOW BALANCE"); ;
            }

        }

        internal void create(int iD, string name, int _balance)
        {
            throw new NotImplementedException();
        }
    }
}
