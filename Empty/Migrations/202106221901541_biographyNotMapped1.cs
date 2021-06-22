namespace Empty.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class biographyNotMapped1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "Biography", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "Biography");
        }
    }
}
