using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqmethod1
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 10, 90, 88, 3 };
            var Inum = arr.Where(i => i > 5);
            foreach (int i in Inum)
            {
                Console.WriteLine(i);
            }

        }
    }
}
