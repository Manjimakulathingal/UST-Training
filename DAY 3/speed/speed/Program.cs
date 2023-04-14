using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace speed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double distance = 0;
            Console.WriteLine("enter the distance: ");
            distance = double.Parse(Console.ReadLine());
            double time = 0;
            Console.WriteLine("enter time: ");
            time = double.Parse(Console.ReadLine());
            double speed1 = speed11(distance, time);
            double speed2 = speed22(distance, time);
            Console.WriteLine($"speed in km/hr:{speed1}");
            Console.WriteLine($"speed in mile/hr:{speed2}");

        }

        static double speed11(double distance, double time)
        {
        return distance* time;
        }

        static double speed22(double distance, double time)
        {
            return (distance * time)/1.6;
        }


    }
}
