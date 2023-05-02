using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraylist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arlist2 = new ArrayList()
                {
                    2, "Steve", " ", true, 4.5, null
                };
            Console.WriteLine(arlist2);
        }
    }
}
