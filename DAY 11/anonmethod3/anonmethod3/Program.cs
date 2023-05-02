using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anonmethod3
{
    internal class Program
    {
        public delegate int Multiply(int x, int y);
        static void Main(string[] args)
        {
            int result;
            Multiply m = delegate (int x, int y)
            {
                return x * y;
            };
            result = m(10, 30);
            Console.WriteLine(result);

        }
    }
}
