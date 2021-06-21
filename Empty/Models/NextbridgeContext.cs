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
        {

         }
        public DbSet<Employee> employees { get; set; }
    }
}