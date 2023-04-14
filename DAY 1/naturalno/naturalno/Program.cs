using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace naturalno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("enter a no:");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);

            }
            
        }
    }
}
