using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqflower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] flowers = { "dahlia", "rose", "daffodils","lilly" };
           /* var fquery =
                from flower in flowers
                where (flower.StartsWith("d"))
                select flower;*/

            

            var fquery = from flower  in flowers
                         let len = flower.Length
                         where len > 5 && len < 7
                         select flower;
            foreach (string f in fquery)
            {
                Console.WriteLine(f);
            }
        }
    }
}
