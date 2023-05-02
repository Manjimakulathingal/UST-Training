using System;
using System.Collections;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace suminarray
{
 
public class HelloWorld
        {

            public static void subArraySum(int[] arr, int n, int sum)
            {

                
                for (int i = 0; i < n; i++)
                {
                    int currentSum = arr[i];

                    if (currentSum == sum)
                    {
                        Console.WriteLine("Sum found at indexe " + i);
                        return;
                    }
                    else
                    {

                        
                        for (int j = i + 1; j < n; j++)
                        {
                            currentSum += arr[j];

                            if (currentSum == sum)
                            {
                                Console.WriteLine("Sum found between indexes " + i + " and " + j);
                                return;
                            }
                        }
                    }
                }
                Console.WriteLine("No subarray found");
                return;
            }

            public static void Main(string[] args)
            {
                int[] arr = { 15, 2, 4, 8, 9, 5, 10, 23 };
                int n = arr.Length;
                int sum = 23;
                subArraySum(arr, n, sum);
            }
        }

       

    }


           
        
    
