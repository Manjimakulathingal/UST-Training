using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
delegate void sumIt();

namespace anonmethod2
{
    internal class Program
    {
        public delegate int sum(int x, int y);
        static void Main(string[] args)
        {
            int result;
            sum s = delegate (int x, int y)
            {
                return x + y;
            };
            result = s(10, 30);
            Console.WriteLine(result);






        }
       
    }
}