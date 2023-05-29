using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace powof2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool check = isPowerOfTwo(8);

            Console.WriteLine(check);

            Console.ReadKey();

        }

        public static  bool isPowerOfTwo(int x)

        {

            while (((x % 2) == 0) && x > 1)

            {

                x /= 2;

            }

            return (x == 1);

        }

    }
}
