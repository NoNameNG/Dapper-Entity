using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Model;

namespace EF
{
    public class Context: DbContext
    {
        public Context() : base("DbEmps") { }
        public DbSet<Employee> Employees { get; set; }

        public DbSet<Equipment> Equipments { get; set; }

        //public Context() : base("DbEmps") { }


    }
}
