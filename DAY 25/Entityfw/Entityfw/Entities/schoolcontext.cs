using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entityfw.Entities
{
    public class schoolcontext : DbContext
    {
        public schoolcontext() : base()
        { 

        }
        public DbSet<student> students { get; set; }
        public DbSet<Grade> Grades { get; set; }

    }
}
