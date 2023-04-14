using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace average
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                int[] nums = { 1, 2, 3, 5, 4, 2, 3, 4 };
                Console.WriteLine((nums));
                int[] nums1 = { 2, 4, 2, 6, 4, 8 };
                Console.WriteLine((nums1));
                double average = nums1.Average();
                

                Console.WriteLine("The average is {0}", average);
            }
        }

    }
}
