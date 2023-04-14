using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace abstractclass
{
    internal abstract class Program
    {
        static void Main(string[] args)
        {

            figure FIG = new square();
            FIG.Dimension = 10;
            Console.WriteLine(FIG.Area);
            Console.WriteLine(FIG.Perimeter); }


        abstract class figure; 
        public int Dimension;
        public abstract double Area();
        public abstract double Perimeter();
        }
    class square : figure
    {
        public override double area()
        {
            return Dimension * Dimension;
        }

        public override double Perimeter()
        {
            return 4 * Dimension;
        }
    }


    }

