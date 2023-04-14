using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selection_sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input the array size: ");
            int size = int.Parse(Console.ReadLine());
            int [] arr =  new int [size];
            Console.WriteLine("enter array list: ");
            for (int i = 0;i <size ; i++) {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int temp;
            for(int i = 0; i<size-1; i++)
            {
                for(int j = 0; j < size-i-1; j++)
                {
                    if (arr[j] < arr[j+1]) {
                        
                        temp = arr[j];
                        arr[j] = arr[j+1];
                        arr[j+1] = temp;
                    
                    }
                    
                }
            }

            Console.WriteLine("sorted array is: ");
            for(int i = 0; i<size; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
