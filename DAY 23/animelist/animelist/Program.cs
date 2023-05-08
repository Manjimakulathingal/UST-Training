using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animelist
{
    internal class Program
    {
        static void Main(string[] args)
        
        {
            List<ani> list = new List<ani>();
            list.Add(new ani("dfgh", "dfghjk", 5));
            list.Add(new ani("sxdcvbn", "sdfgh", 8));
            list.Add(new ani("sxcvbn", "xcvbn", 9));

            var Ia = list.Where(s => s.Rate > 6).ToList<ani>();
            foreach (var s in Ia)
            {
                Console.WriteLine(s.Name);
            }
        }
        
    }
}
