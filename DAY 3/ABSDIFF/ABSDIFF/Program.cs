using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABSDIFF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n = 0;
            Console.WriteLine("enter a no: ");
            n = double.Parse(Console.ReadLine());
            double ans = Abs(n);
            Console.WriteLine(ans);



        }
        static double Abs(double x)
        {
            if (x > 51)
            {
                 x = Math.Abs(x - 51);
                return x * 3;


            }
            else
            {
                return Math.Abs(x - 51);

            }

        }
    }
}
