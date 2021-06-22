namespace Empty.Migrations
{
    using Empty.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Empty.Models.NextbridgeContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Empty.NextbridgeContext";

        }

        protected override void Seed(Empty.Models.NextbridgeContext context)
        {

            context.Genders.AddOrUpdate(x => x.ID,
                new Gender() { ID = 1, Value = "Male" },
                new Gender() { ID = 2, Value = "Female" }
                );

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
