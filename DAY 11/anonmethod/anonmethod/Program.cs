﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
delegate void CountIt();

namespace anonmethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CountIt count = delegate
            {
                for (int i = 0; i <= 10; i++)
                    Console.WriteLine(i);
            };
            count();
        }
    }
}
