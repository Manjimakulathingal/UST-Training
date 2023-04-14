using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumofn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int sum = 0;
            Console.WriteLine("enter a no:");
            int n = int.Parse(Console.ReadLine());
            


            for (i = 1; i <= n; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine(sum);

        }
    }
}
