using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[4];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());

            }

            //output largesr integer

            /*  for(int i =0; i < arr.Length;i++)
              {
                  if (arr[i] > arr[i + 1])
                  {
                      Console.WriteLine(arr[i]);
                  }


              //odd even
                 for(int i = 0; i < arr.Length;i++)
              {
                  if (arr[i] % 2 == 0)
                  {
                      Console.WriteLine("even number elments are: "+ arr[i]);
                  }
                  else {
                      Console.WriteLine("odd number elements are: " + arr[i]);}
              }

            //ascending order
            
            int temp;
            for(int i =0; i < arr.Length;i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
            Console.WriteLine("ao: ");

            for (int i = 0; i < arr.Length;i++)
            {
                Console.Write( + arr[i]);
            }

            //descneindg order

            int temp;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
            Console.WriteLine("ao: ");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(+arr[i]);
            }

            // find the 2nd largest

            int lrg1 , lrg2 ;
            for(int i = 0; i < arr.Length; i++)
            {
                if(lrg1 < arr[i]) 
                {
                    lrg1 = arr[i];
                    i = j;

                }
            }
            lrg2 = 0;
            for( int i = 0; i < arr.Length;i++)
            {
                if(i == j)
                {
                    i++;
                    i--;

                }
                else
                {
                    lrg2 < arr[i];
                    lrg2 = arr[i];
                }

            }

        }*/
        }

    }
}

