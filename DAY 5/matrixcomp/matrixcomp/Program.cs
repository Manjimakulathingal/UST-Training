using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrixcomp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] a = new int[2, 2];
            Console.WriteLine("enter matrix values");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            int[,] b = new int[2, 2];
            Console.WriteLine("enter matrix values");
            {
                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        a[i, j] = int.Parse(Console.ReadLine());
                    }
                }
                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {

                        if (a[i, j] == b[i, j])
                        {
                            Console.WriteLine("equal");

                        }
                        else
                        {
                            Console.WriteLine("not");
                        };
                        break;







                    }
                }
            }
        }
    }
}