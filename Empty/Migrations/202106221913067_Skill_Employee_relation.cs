namespace Empty.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Skill_Employee_relation : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SkillEmployees",
                c => new
                    {
                        Skill_ID = c.Int(nullable: false),
                        Employee_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Skill_ID, t.Employee_ID })
                .ForeignKey("dbo.Skills", t => t.Skill_ID, cascadeDelete: true)
                .ForeignKey("dbo.Employees", t => t.Employee_ID, cascadeDelete: true)
                .Index(t => t.Skill_ID)
                .Index(t => t.Employee_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SkillEmployees", "Employee_ID", "dbo.Employees");
            DropForeignKey("dbo.SkillEmployees", "Skill_ID", "dbo.Skills");
            DropIndex("dbo.SkillEmployees", new[] { "Employee_ID" });
            DropIndex("dbo.SkillEmployees", new[] { "Skill_ID" });
            DropTable("dbo.SkillEmployees");
        }
    }
}
