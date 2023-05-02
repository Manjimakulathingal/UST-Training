using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortedlist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList S = new SortedList();
            S.Add("MAHARASTRA", "MUMBAI");
            S.Add  ("TVM ", "KERALA");
            S.Add("CHENNAI", " TN");
           foreach (var item in S.Keys)
            {
                Console.WriteLine(item);
            }
           
        }
    }
}
