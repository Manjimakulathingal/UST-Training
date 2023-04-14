using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace palindrome
{
    internal class Program
    {
        private static object inputString;
        private static int i;

        static void Main(string[] args)
        {
            Console.WriteLine("enter a string: ");
            string str = Console.ReadLine();
            for (int i = str.Length - 1; i >= 0; i--)
            {
                Console.Write(str[i]);







            }
        }


    }
}

