using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace string1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string greeting;
            Console.WriteLine("write a string:");
            greeting = Console.ReadLine();
            Console.WriteLine("string is :" + greeting);
        }
    }
}
