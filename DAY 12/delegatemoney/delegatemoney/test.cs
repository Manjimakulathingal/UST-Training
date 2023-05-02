using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace delegatemoney
{
    class Test

    {

        static void Main()

        {
            {

    Rupee m1 = new Rupee(1000, 55);
        Dollar m2 = new Dollar(100, 75);

        Print[] p = new Print[2];

        p[0] = new Print(m1.Display);

        p[1] = new Print(m2.Info);
        write(p);

    }

        static void write(Print[] p)

    {

        p[0]();

        p[1]();

    }

}
    }
}
