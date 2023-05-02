using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @delegate
{
    internal class Program
    {
        static void Add(int i , int j)
        {
            Console.WriteLine("sum: "+ (i +j));
        }
        static void Sub(int i, int j)
        {
            Console.WriteLine("sub: " + (i - j));
        }
        static void Multiply(int i, int j)
        {
            Console.WriteLine("mul: " + (i - j));
        }

        public delegate void refto(int i , int j);
        static void Main(string[] args)
        {
            
           

              Add(5, 2);
              refto r1 = Add;
              r1(5, 2);
              refto r2 = Sub;
                  r2.Invoke(5,2); 


        }
    }
}
