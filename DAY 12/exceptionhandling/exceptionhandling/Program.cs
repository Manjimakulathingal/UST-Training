using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptionhandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int k = 10;
            Console.WriteLine("enter the value");
            int i = int.Parse(Console.ReadLine());

            try
            {
                
                k = k / i;
                Console.WriteLine("hello");
            }
            catch 
             
               (Exception e)
            { Console.WriteLine(e.ToString()); }
            

            
          }
            
        }
    }

