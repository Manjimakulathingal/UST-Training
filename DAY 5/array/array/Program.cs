using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    internal class Program
    {
        static void Main(string[] args)
        { }
        class TestArraysClass
        {
            static void Main()
            {
                Console.WriteLine("size:");
                int size = Convert.ToInt32(Console.ReadLine());
                int[] arr = new int[size];
                for (int i = 0; i < size; i++)
                {
                    Console.WriteLine("enter element {i + 1}:");
                    arr[i] = int.Parse(Console.ReadLine());
                }
            }
        }
    }  }


