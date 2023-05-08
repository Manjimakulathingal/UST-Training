using Entityfw.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entityfw
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new schoolcontext())
            {
                var stud = new student() { StudentName = "Bill" };

                ctx.students.Add(stud);
                ctx.SaveChanges();
            }
        }
    }
}
