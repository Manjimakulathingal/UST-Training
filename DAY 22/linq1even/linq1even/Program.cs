using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq1even
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 12, 3, 4, 5, 2, 3, 0, 9, 7 };
            var num = from n in arr
                      where n%2 == 0
                      select n;
            foreach (int x in num)
            {
                Console.WriteLine(x);
            }
        }
    }
}
