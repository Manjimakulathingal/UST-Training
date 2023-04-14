using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datetime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dT = DateTime.Now;
            Console.WriteLine(dT);

            DateTime dt2 = new DateTime(2015, 12, 31);
            Console.WriteLine(dt2);

            DateTime dTT3 = new DateTime(2016,11, 31,50,12,5);
            Console.WriteLine(dTT3);

            DateTime dt4 = new DateTime(2015, 12, 31, 5, 10, 20, DateTimeKind.Utc);
            Console.WriteLine(dt4);

            

            DateTime currentDateTime = DateTime.Now; 
            DateTime todaysDate = DateTime.Today;
            DateTime currentDateTimeUTC = DateTime.UtcNow;
        }
    }
}
