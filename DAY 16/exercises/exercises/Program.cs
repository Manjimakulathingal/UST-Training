using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace exercises
{
    internal class Program
    {
        class test {
            int marks;
            void Calcpercent();{

        int percent = (this.marks * 100) / 50;
            Console.WriteLine(percent);
        }
        static void Main(string[] args)
            {
                test t1 = new test();
                t1.marks = 40;
                t1.Calcpercent();


            }

            /*  static void ADD(int j , int i)
              {
                  int sum = i + j;
                  Console.WriteLine(sum);
              }

              static void Main(string[] args)
              {

                  Console.WriteLine("hello");
                  ADD(10,20);
                  Console.WriteLine("world");

                  /*  int[] A = new int[] { 1, 2, 7, 6, 5, 8, 3 };
                    int temp;
                    for (int i = 0; i < A.Length; i++)
                    {
                        for(int j = 0; j <A.Length-1; j++)
                        {
                            if (A[j + 1] > A[j])
                            {

                                temp = A[j];
                                A[j] = A[j+1];
                                A[j+1] = temp;
                            }

                        }

                    }
                    foreach (int item in A)
                    {
                        Console.WriteLine(item);
                    }
                } */


            /*   int[] A = new int[] { 2, 4, 7, 8, 5, 0, 1 };
               Console.WriteLine("enter a digit");
               int num = int.Parse(Console.ReadLine());
               bool found = false;
               for(int i = 0; i < A.Length; i++) {
                   if (A[i] == num) {  found = true; break; }

               }

               if (!found)
               { Console.WriteLine("num not found");
               }
               else
               {
                   Console.WriteLine("num found");
               }


               } */

        }

}

