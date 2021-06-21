using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Empty.Models
{
    public class Nextbridge:DbContext
    {
        public Nextbridge():base("SchoolDbContext")
        {
         }
        public DbSet<Employee> employees { get; set; }
    }
}