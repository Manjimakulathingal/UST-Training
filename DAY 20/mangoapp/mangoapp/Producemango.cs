﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mangoapp
{
    internal class Producemango
    {
        public event EventHandler<MangoEventArgs> MangoInfo;
        string Mango;
        public Producemango(string type)
        {
            Mango = type;
        }
        public void FreshLot()
        {
            int i = new Random().Next(1000);
            string mangoinfo = i + " " + Mango + " mangoes produced ";
            Console.WriteLine(mangoinfo);
            if (MangoInfo != null)
            {
                MangoInfo(this, new MangoEventArgs(Mango, i));
            }


        }
    }
}
