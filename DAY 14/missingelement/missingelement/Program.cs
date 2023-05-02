using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace missingelement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[100];
            int total = 0;
            int element;
            Console.WriteLine("enter the size:");
            int n = int.Parse(Console.ReadLine());
            int sum = n * (n + 1) / 2;

            Console.WriteLine("enter the elements:");
            for(int i = 0; i <n-1; i++) {
                arr[i] = int.Parse(Console.ReadLine());
                total += arr[i];
            
            }

            element = sum - total;
            Console.WriteLine(element);
        }
    }
}
