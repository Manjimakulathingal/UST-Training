using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    public class Program
    {
        static void Main(string[] args)
        {
            Orange e1 = new Orange(1, "orange", "kerala");
            e1.print();


        }
        public class fruit
        {
            private int _number;
            private string _name;
            public string Name
            {
                get { return _name; }
                set { _name = value; }
            }
            public int Number
            {
                get { return _number; }
                set { _number = value; }
            }

            public fruit()
            {

            }

            public fruit(int number, string name)
            {
                _number = number;
                _name = name;
            }




            public void print()
            {
                Console.WriteLine("fruit no will be:" + _number);
                Console.WriteLine("fruit namne is : " + _name);
            }
    }
        public class Orange : fruit
        {
            private string _origin;
            private string[] states = { "maharastra", "Telangana", "Himachal" };






            public string Origin
            {
                get { return _origin;
                }
                set
                {
                    Array.Sort(states);
                    if (states.Contains(value))
                    {
                        _origin = value;
                    }
                    else { Console.WriteLine("invalid state"); }
                }
            }


            public Orange()
            {

            }

            public Orange(int number, string name, string origin)
                : base(number, name)
            {
                _origin = origin;
            }

            public new void print()
            {
                base.print();
                Console.WriteLine(_origin);
            }














        }
    } }
