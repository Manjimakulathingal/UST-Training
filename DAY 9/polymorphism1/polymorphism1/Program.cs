using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            shape s1 = new shape();
            s1.DrawShape();
            circle C1 = new circle();
            C1.DrawShape();

            shape s2 = new shape();
            s2.DrawShape();


            //array of reference of base class containing 
        }
    }
}
