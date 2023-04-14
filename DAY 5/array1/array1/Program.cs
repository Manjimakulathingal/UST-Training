using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter:");
            int[] array = new int[3];
            int a;
            Console.WriteLine("enter 10 elements:");
            for(int i  = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            for(int i =0; i < array.Length;i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
