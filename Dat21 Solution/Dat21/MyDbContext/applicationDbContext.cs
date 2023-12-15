using System;
using Dat21.Models;
using Microsoft.EntityFrameworkCore;

namespace Dat21.MyDbContext
{
    public class applicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source= .; Initial Catalog = MakeenProject ; Integraated Security=True;");
        }


        public DbSet<Employee> Employees;
        public DbSet<Department> Departments;
        public DbSet<Projects> Project;
    }

    
}

