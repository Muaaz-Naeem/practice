using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Empty.Models
{
    public class NextbridgeContext:DbContext
    {
        public NextbridgeContext()
            :base("SchoolDbContext")
        {

        }
        public DbSet<Employee> employees { get; set; }      
        public DbSet<Gender> Genders { get; set; }      
 
    }
}