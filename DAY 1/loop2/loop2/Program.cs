using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows, i = 0, j = 0;
            Console.WriteLine("ENTER A NO:");
           int  rows = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= rows; i++)
            {
                for (j = 1; j <= i; j++) 
                    Console.Write( i );
                
            }
        }
    }
}
