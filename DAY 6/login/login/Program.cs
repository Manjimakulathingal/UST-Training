using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            checking e1 = new checking();
            bool flag = e1.flag;
            while (flag == true) 
            {
                Console.WriteLine("enter userid and pw:");
                string user = Console.ReadLine();
                string pw = Console.ReadLine();
                e1.function(user,pw);
            }
        }
    }
}
