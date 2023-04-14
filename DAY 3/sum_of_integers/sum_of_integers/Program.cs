using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_of_integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;

            Console.WriteLine("enter a digit1: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter a digit2: ");
            b = int.Parse(Console.ReadLine());
            int c = sum(a,b);
            Console.WriteLine(c);
        }

        static int sum(int a, int b)
        {
            if(a == b)
            {
                return 3 *(a + b);
            }
            else
            {
                return a + b;
            }
        }

    }

}
