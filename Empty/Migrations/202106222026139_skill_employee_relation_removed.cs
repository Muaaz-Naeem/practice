namespace Empty.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class skill_employee_relation_removed : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.EmployeeSkill", "EmployeeID", "dbo.Employees");
            DropForeignKey("dbo.EmployeeSkill", "SkillID", "dbo.Skills");
            DropIndex("dbo.EmployeeSkill", new[] { "EmployeeID" });
            DropIndex("dbo.EmployeeSkill", new[] { "SkillID" });
            DropTable("dbo.EmployeeSkill");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.EmployeeSkill",
                c => new
                    {
                        EmployeeID = c.Int(nullable: false),
                        SkillID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.EmployeeID, t.SkillID });
            
            CreateIndex("dbo.EmployeeSkill", "SkillID");
            CreateIndex("dbo.EmployeeSkill", "EmployeeID");
            AddForeignKey("dbo.EmployeeSkill", "SkillID", "dbo.Skills", "ID", cascadeDelete: true);
            AddForeignKey("dbo.EmployeeSkill", "EmployeeID", "dbo.Employees", "ID", cascadeDelete: true);
        }
    }
}
