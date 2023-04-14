using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_telephone
{
    internal class Electronicphone : Telephone
    {
        public Electronicphone() 
        { 

        }
        public Electronicphone(string phonetype)
               :base(phonetype)
        { }

        public void Run()
        {
            base.Ring();
        }
    }
}
