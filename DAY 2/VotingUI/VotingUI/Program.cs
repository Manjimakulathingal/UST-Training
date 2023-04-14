using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 0;
            Console.WriteLine("enter age: ");
            age = int.Parse(Console.ReadLine());
            string b;
            b = Checking(age);
            Console.WriteLine((b));

        }
        static string Checking(int age) 
        {
            string c;
            if( age >= 18 ) {
                return "eligible";


            }
            else {
                return "not eligible";
            }
            return c;
        }
    }
}
