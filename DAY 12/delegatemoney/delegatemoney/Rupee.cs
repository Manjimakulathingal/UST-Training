using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace delegatemoney
{

    class Rupee : money
    {
        public Rupee(uint n, uint c) : base(n, c)
        {
        }
    }

    public Rupee(uint rupees, uint paise) : base(rupees, paise) { }

    public void Display()

        {

            Console.WriteLine("Rs. {0}.{1}", note, coin);

        }
    }

