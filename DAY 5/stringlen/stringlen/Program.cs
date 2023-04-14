using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace stringlen
{
    internal class Program
    {
        static void Main(string[] args, string v)
        {
            Console.WriteLine("enter a string:");
            string str;
            str = Console.ReadLine();
            int a = total(str);
            Console.WriteLine(a);
        }
        static int total(string str)
        {
            int b = 0;
            foreach (char i in str) {
                b = b + i;

            }
            return b;
        }
    }
}
