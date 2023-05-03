using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emplistlinq
{
    internal class Employee
    {
        private string name;

        

        public string Name
        {
            get { return name; }
            set { name = value; }
        }





        private string city;

        

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public Employee() { }

        public Employee(string name, string city)
        {
            this.name = name;
            this.city = city;
        }

    }
}
