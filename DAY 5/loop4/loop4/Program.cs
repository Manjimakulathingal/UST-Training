﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j, r;
            r = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i <= r; i++)
            {
                for (j = 1; j <= r - i; j++)
                    Console.Write(" ");
                for (j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");
                Console.Write("\n");
            }

            for (i = r - 1; i >= 1; i--)
            {
                for (j = 1; j <= r - i; j++)
                    Console.Write(" ");
                for (j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");
                Console.Write("\n");
            }
        }
    }
}
