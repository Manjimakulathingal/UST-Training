using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptionhandle2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("enter the value of i:");
            int i = int.Parse(Console.ReadLine());
            try
            {
                int[] a = new int[5];

                int k = 10;
                k = k / i;
                a[10] = 9;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(IndexOutOfRangeException e) 
            {
                Console.WriteLine(e.Message);

            
            }
            finally
            {
                Console.WriteLine("finally");
            }
            Console.WriteLine("remaining program");
        }
    }
}
