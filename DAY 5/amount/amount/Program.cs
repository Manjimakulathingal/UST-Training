using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace amount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("enter an amount:");

            int b = int.Parse(Console.ReadLine());

            amt = amt / 2000;
            amt = amt % 2000;
            amt = amt / 500;
            amt = amt % 500;
            amt = amt / 100;
            amt = amt % 100;
            amt = amt / 50;
            amt = amt % 50;
            amt = amt / 20;
            amt = amt % 20;
            amt = amt / 10;
            amt = amt % 10;
            Console.WriteLine(amt);

            */
            
            Console.WriteLine("enter an amount: ");
            int amt = int.Parse(Console.ReadLine());
            int[] arr = { 2000, 500, 100, 50, 20, 10, 5,2,1 };
            for (int i = 0; i < 9; i++)
            {
                int a = amt / arr[i];
                 amt  = amt %= arr[i];
                Console.WriteLine(a);
            }



        }
            }

        }
    

