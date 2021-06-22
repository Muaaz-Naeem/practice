namespace Empty.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class skill_employee_relationBy_Fluent : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EmployeeSkills",
                c => new
                    {
                        Employee_ID = c.Int(nullable: false),
                        Skill_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Employee_ID, t.Skill_ID })
                .ForeignKey("dbo.Employees", t => t.Employee_ID, cascadeDelete: true)
                .ForeignKey("dbo.Skills", t => t.Skill_ID, cascadeDelete: true)
                .Index(t => t.Employee_ID)
                .Index(t => t.Skill_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.EmployeeSkills", "Skill_ID", "dbo.Skills");
            DropForeignKey("dbo.EmployeeSkills", "Employee_ID", "dbo.Employees");
            DropIndex("dbo.EmployeeSkills", new[] { "Skill_ID" });
            DropIndex("dbo.EmployeeSkills", new[] { "Employee_ID" });
            DropTable("dbo.EmployeeSkills");
        }
    }
}
