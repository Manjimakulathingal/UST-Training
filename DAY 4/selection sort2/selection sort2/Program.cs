using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace selection_sort2
{
    internal class Program
    {


        static void Main(string[] args)
        {
            int n = 0;
            Console.WriteLine("enter the size of the array: ");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            Console.WriteLine("enter the array list: ");
            for (int i = 0; i < size; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int temp, smallest;
            for (int i = 0; i < n - 1; i++)
            {
                smallest = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[smallest])
                    {
                        smallest = j;
                    }
                }
                temp = arr[smallest];
                arr[smallest] = arr[i];
                arr[i] = temp;
            }
            
            
            for (int i = 0; i < n; i++)
            {
                Console.Write("Sorted array is: " + arr[i]);
                
            }
        }
    }
}



