using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* string str;
             int i = 0;
             Console.Write("Input the string : ");
             str = Console.ReadLine();

             Console.Write("The characters of the string are  :  ");
             while (1 != str.Length)
             {
                 Console.Write(str);
             }*/
            int i = 0;
            int n = 10;
           
            n =int.Parse(Console.ReadLine());
            for(i=1; i<n; i++)
            {
                Console.WriteLine(i);
            }
        }

    }
}
