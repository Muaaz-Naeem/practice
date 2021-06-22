namespace Empty.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GenderModelAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Genders",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Value = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Genders");
        }
    }
}
