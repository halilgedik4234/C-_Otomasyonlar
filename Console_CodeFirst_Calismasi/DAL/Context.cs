using Console_CodeFirst_Calismasi.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_CodeFirst_Calismasi.DAL
{
    public class Context:DbContext
    {
        public DbSet <Customer> Customers { get; set; }

        public DbSet<Job> Jobs { get; set; }

        public DbSet<Employee> Employees { get; set; }


    }
}
