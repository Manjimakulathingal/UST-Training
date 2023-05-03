using emplistlinq;
using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace Linq_groupby

{

    internal class Program

    {

        static void Main(string[] args)
        {
            List<Employee> EmpList = new List<Employee>();

            {
                EmpList.Add(new Employee("shyam", "tvm"));

                EmpList.Add(new Employee("manjima", "pkd"));

                EmpList.Add(new Employee("anusree", "mlp"));

                EmpList.Add(new Employee("anjana", "otp"));

                EmpList.Add(new Employee("liyana", "mlp"));

                EmpList.Add(new Employee("achumma", "kkd"));

            }

            var Equery = from Employee emp in EmpList

                         orderby emp.City

                         group emp by emp.City;
            foreach (var e in Equery)

            {

                Console.WriteLine("Employee with " + e.Key + " City: ");

                foreach (var nm in e)

                {

                    Console.WriteLine(" " + nm.Name);

                }

            }

        }
    }
}







