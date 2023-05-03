using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oddlinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 12, 43, 24, 65, 78, 9 };
            Console.WriteLine("odd no:");
            foreach (int i in num)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
