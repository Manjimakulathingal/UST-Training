using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace delegatemoney
{

    class Dollar : money

    {

        public Dollar(uint dollar, uint cent) : base(dollar, cent) { }

        public void Info()

        {

            Console.WriteLine("${0}.{1}", note, coin);

        }

    }
}
