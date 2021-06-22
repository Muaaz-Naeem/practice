namespace Empty.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class employee_skill_model : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EmployeeSkills",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        EmployeeID = c.Int(nullable: false),
                        SkillID = c.Int(nullable: false),
                        Date = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Employees", t => t.EmployeeID, cascadeDelete: true)
                .ForeignKey("dbo.Skills", t => t.SkillID, cascadeDelete: true)
                .Index(t => t.EmployeeID)
                .Index(t => t.SkillID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.EmployeeSkills", "SkillID", "dbo.Skills");
            DropForeignKey("dbo.EmployeeSkills", "EmployeeID", "dbo.Employees");
            DropIndex("dbo.EmployeeSkills", new[] { "SkillID" });
            DropIndex("dbo.EmployeeSkills", new[] { "EmployeeID" });
            DropTable("dbo.EmployeeSkills");
        }
    }
}
