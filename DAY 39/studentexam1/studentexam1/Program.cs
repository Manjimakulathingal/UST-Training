using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentexam1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
            Console.WriteLine("enter the student type");
            string st = Console.ReadLine();
            if (st == "MSDS")
            {

                Console.WriteLine("ENTER TUITION FEE:");
                float tf = float.Parse(Console.ReadLine());
                Console.WriteLine("ENTER BUS FEE: ");
                float bf = float.Parse(Console.ReadLine());
                Console.WriteLine("enter hostel fee:");
                float hf = float.Parse(Console.ReadLine());
                float sum = tf + bf;
                Console.WriteLine("fee to be paid by the student is {0} + {1} = {2}", tf, bf, sum);

            }
            else if (st == "MSH")
            {
                Console.WriteLine("enter tuition fee");
                float tf = float.Parse(Console.ReadLine());
                Console.WriteLine("enter hostel fee:");
                float hf = float.Parse(Console.ReadLine());
                Console.WriteLine("enter BUS FEE fee:");
                float bf = float.Parse(Console.ReadLine());
                float sum = tf + hf;
                Console.WriteLine("fee to be paid by the student is {0} + {1} = {2}", tf, hf, sum);
            }
            else if (st == "MGSDS")
            {
                Console.WriteLine("enter tuition fee");
                float tf = float.Parse(Console.ReadLine());
                Console.WriteLine("enter BUS fee:");
                float bf = float.Parse(Console.ReadLine());
                Console.WriteLine("enter hostel fee:");
                float hf = float.Parse(Console.ReadLine());
                float sum = tf + bf;
                Console.WriteLine("fee to be paid by the student is {0} + {1} = {2}", (1.5 * tf), bf, sum);
            }
            else if (st == "MGSH")
            {
                Console.WriteLine("enter tuition fee");
                float tf = float.Parse(Console.ReadLine());
                Console.WriteLine("enter hostel fee:");
                float hf = float.Parse(Console.ReadLine());
                Console.WriteLine("enter BUS FEE fee:");
                float bf = float.Parse(Console.ReadLine());
                float sum = tf + hf;
                Console.WriteLine("fee to be paid by the student is {0} + {1} = {2}",(1.5* tf), hf, sum);
            }

        }
    }
}
