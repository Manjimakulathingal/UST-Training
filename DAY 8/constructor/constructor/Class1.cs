using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor
{
    public class Emp
    {
        public int EmpID;
        public string Name;
        public Decimal salary;
        public Emp()
        {

        }
        public Emp(int EmpID, string name, decimal sALARY)
        {
            EmpID = EmpID;
            Name = name;
            this.salary = sALARY;

        }
    }
}

