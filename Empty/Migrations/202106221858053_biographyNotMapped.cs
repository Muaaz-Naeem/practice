namespace Empty.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class biographyNotMapped : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Employees", "Biography");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Employees", "Biography", c => c.String());
        }
    }
}
