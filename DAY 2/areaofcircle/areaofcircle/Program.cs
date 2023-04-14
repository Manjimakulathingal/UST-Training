// See https://aka.ms/new-console-template for more information
using System;


namespace area
{
    class one
    {
        static void Main(string[] args)
        {
            double r = 0.0;
            double area=0.0;
            Console.WriteLine("enter the radius: ");
            r = double.Parse(Console.ReadLine());
            area = CaArea(r);
            Console.WriteLine($"area:  {area}");
        }
        
        static double CaArea(double e)
        {
            double area = 0;
            return area = 3.14 * e * e;
        }

    }       
            
}
    



