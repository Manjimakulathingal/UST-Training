using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sqlinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] number = new [] { 1, 2, 3, 4, 5, 6, };
            var num1 = from int num in number

                       let a = num * num
                       select num;
                       

            
            foreach(var a  in num1)
            {
                Console.WriteLine(a );

            }


            


        }
    }
}



/*
var a = from int Number in arr1
           let SqrNo = Number * Number
           where SqrNo > 20
           select new { Number, SqrNo };

foreach (var a in sqNo)*/
