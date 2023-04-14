using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop3
{
    internal class Program
    {
        static void Main(string[] args)
        {

           

            
            {
                int i, x;
                

                Console.Write("Input number of terms : ");
                x = Convert.ToInt32(Console.ReadLine());
                for (i = 1; i <= x; i++)
                {
                    Console.Write("Number is : {0} and cube of the {1} is :{2} \n", i, i, (i * i * i));
                }
            }
        }

    }
}

