using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            Emp e1 = new Emp();
            Emp e2 = new Emp(11 , "gfff" , 121);
            Console.WriteLine("enter emp id: ");
            e1.EmpID = int.Parse(Console.ReadLine());
            Console.WriteLine("enter employee name: ");
            e1.Name = Console.ReadLine();
            Console.WriteLine("enter employee salary");
            e1.salary = decimal.Parse(Console.ReadLine());
            Console.WriteLine(  e1.Name);

        }
    }

}
