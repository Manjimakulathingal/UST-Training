using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace arrayexercises
{
    internal class Program
    {





        /*  Console.WriteLine("array is:");
          int[] arr = new int[6];
          for(int i = 0; i <6; i++)
          {
              int i = int.Parse(Console.ReadLine());
              Console.WriteLine(arr[i]);
          } */
        /* int a;
         Console.WriteLine("Enter size of index:");
         a = int.Parse(Console.ReadLine());
         int[] index = new int[a];
         for (int i = 0; i < a; i++)
         {

             index[i] = int.Parse(Console.ReadLine());
         }

         int n;
         Console.WriteLine("enter the size");
         n = int.Parse(Console.ReadLine());
         int[] arr = new int[n];
         for( int i = 0; i <n; i++)
         {

             arr[i] = int.Parse(Console.ReadLine());




         }
         Console.WriteLine("elements before reversing");

         for (int i = n; i <= 0; i--)
         {

             arr[i] = int.Parse(Console.ReadLine());



         }
         Console.WriteLine("elements after reversing");

     }

        {
            int i, n;
            int[] a = new int[100];


            Console.Write("Input the number of elements to store in the array :");
            n = Convert.ToInt32(Console.ReadLine());


            Console.Write("Input {0} number of elements in the array :\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }



            Console.Write("\n\nThe values store into the array in reverse are :\n");
            for (i = n - 1; i >= 0; i--)
            {
                Console.Write("{0} ", a[i]);
            }
            Console.Write("\n\n");
        }
        int sum = 0;
        int[] arr = new int[4];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(arr[i]);
        }
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        // C# program to count frequencies of array items

        public static void countFreq(int[] arr, int n)
        {
            bool[] visited = new bool[n];

            // Traverse through array elements and
            // count frequencies
            for (int i = 0; i < n; i++)
            {

                // Skip this element if already processed
                if (visited[i] == true)
                    continue;

                // Count frequency
                int count = 1;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        visited[j] = true;
                        count++;
                    }
                }
                Console.WriteLine(arr[i] + " " + count);
            }
        }


        public static void Main(String[] args)
        {
            int[] arr = new int[] { 10, 20, 20, 10, 10, 20, 5, 20 };
            int n = arr.Length;
            countFreq(arr, n);
        }
    }*/

        

      

}
}





