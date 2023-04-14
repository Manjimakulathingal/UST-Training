using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conversion
{
    internal class Program
    {
        static void Main(string[] args, int[] arr)
        {

            int n = 10;
            Console.WriteLine("enter the digit: ");
            int dec = int.Parse(Console.ReadLine());
            int[] ints = new int[10];
            int[] arr = new int[] ;
            int j = 0;
            for (int i = 0; n>0; i++)
            {
                int[] arr1 = arr;
                arr1[i] = n % 2;
                
                dec = dec / 2;
                j++;
            }
            for (int i= j+1; i >= 0; i--)
            {
                Console.WriteLine(arr[i]);
            }
             
            
            
           





        }
            

        }
    }

