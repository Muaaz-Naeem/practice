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
        public DbSet<Employee> Employees { get; set; }      
        public DbSet<Gender> Genders { get; set; }      
        public DbSet<Skill> Skills { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Employee>()
            //                .HasMany(s => s.Skills)
            //                .WithMany(e => e.Employees)
            //                .Map(c=> {
            //                    c.MapLeftKey("EmployeeID");
            //                    c.MapRightKey("SkillID");
            //                    c.ToTable("EmployeeSkill");
            //                });
        }

    }
}