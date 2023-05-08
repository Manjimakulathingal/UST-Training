using EMPDB;
using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace EFDemo1

{

    internal class Program

    {

        static void Main(string[] args)
        {

           EmpEntities emp = new EmpEntities();

            foreach (var item in emp.Depts)

            {

                Console.WriteLine(item.DeptName);

            }

           /* using (var context = new EmpEntities())

            {

                var Dept = new Dept()

                {

                    DeptId = 110,

                    DeptName = "IT"

                };

                context.Depts.Add(Dept);

                context.SaveChanges();
            }

            using (var context = new EmpEntities())
            {
                var dept = context.Depts.First<Dept>();
                dept.DeptName = "kulam";
                context.SaveChanges();
            }
            using (var context = new EmpEntities())
            {
                var dept = context.Depts.First<Dept>();
                context.Depts.Remove(dept);
                context.SaveChanges();

            }*/

           
        }
    }
}


