using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace account
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ch;
            Account a = null;
            do
            {
                Console.WriteLine("1. create account: ");
                Console.WriteLine("2. Deposit amount: ");
                Console.WriteLine("3. withdraw amount: ");
                Console.WriteLine("4. quit");
                Console.WriteLine("enter choice: ");
                ch = int.Parse(Console.ReadLine());

                switch (ch)
                {
                    case 1:
                        Console.WriteLine("enter account ID:");
                        int ID = int.Parse(Console.ReadLine());
                        Console.WriteLine("enter name: ");
                        string name = Console.ReadLine();
                        Console.WriteLine("enter availible balance:");
                        int balance = int.Parse(Console.ReadLine());

                        a = new Account();
                        a.create(ID,name,balance);
                        break;
                        case 2:
                        if (a != null)
                        {
                            a.display();

                        }
                        else { Console.WriteLine("open account"); };
                        break;
                        case 3:
                        if (a != null)
                            a.deposit(100);
                        else { Console.WriteLine("open account"); };
                        break;
                        case 4:
                        if (a != null)
                        {
                            a.Withdrawal(100);
                        }
                        else { Console.WriteLine("open account"); };
                        break;
                        
                        case 5:
                        if (a != null)
                        {
                            Console.WriteLine(a.Balance);
                        }
                        else
                        {
                            Console.WriteLine("create account first");

                        }
                        break;

                        
                        default: Console.WriteLine("wrong choice");
                        break;
                }
            }
            while (ch != 0);
            Console.WriteLine("thanks");
        }
    }
}
