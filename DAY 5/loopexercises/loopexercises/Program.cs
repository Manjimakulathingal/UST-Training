﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loopexercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;

            for (int i = 0; i <= 3; i++)
            {
                for(int j = 0; j <= 3; j++)
                {
                    for(int k = 0; k <= 3; k++)
                    {
                        Console.WriteLine("{0}  {1}  {2}" , i , j , k);

                    }
                }

                
            }
        }
    }
}
