using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mangoapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsumeMango Slice = new ConsumeMango();
            Producemango SalemFarms = new Producemango("Alphanso");
            // Slice registers event with SalemFarms
            SalemFarms.MangoInfo += Slice.SqueeezeMango;
            SalemFarms.FreshLot();
        }
    }
}
