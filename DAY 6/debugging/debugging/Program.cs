using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace debugging
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("enter a no:");
            int i = int.Parse(Console.ReadLine());
            Console.WriteLine("enter a no2:");
            int j = int.Parse(Console.ReadLine());
            foo(i, j);
            Console.WriteLine("debugging over");

        }
        public static void foo(int x, int y)
        {
            int t = 100;
            for (int i = x; i <= y; i++)
            {
                Console.WriteLine("manjima");
                t = t + 34;
            }

        }

    }
}
