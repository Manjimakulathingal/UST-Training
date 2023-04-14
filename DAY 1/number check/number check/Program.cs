using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number_check
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] stringArray = { "L", "A", "P" };
            string value = "P";
            int index = Array.IndexOf(stringArray, value);
            if (index > -1)
            {
                Console.WriteLine("{0} found ", value, index);
            }
            else
            {
                Console.WriteLine(" not found");
            }
        }
    }
}
