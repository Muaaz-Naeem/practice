namespace Empty.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class skill_employee_relation_fluent_maped : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.EmployeeSkills", newName: "EmployeeSkill");
            RenameColumn(table: "dbo.EmployeeSkill", name: "Employee_ID", newName: "EmployeeID");
            RenameColumn(table: "dbo.EmployeeSkill", name: "Skill_ID", newName: "SkillID");
            RenameIndex(table: "dbo.EmployeeSkill", name: "IX_Employee_ID", newName: "IX_EmployeeID");
            RenameIndex(table: "dbo.EmployeeSkill", name: "IX_Skill_ID", newName: "IX_SkillID");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.EmployeeSkill", name: "IX_SkillID", newName: "IX_Skill_ID");
            RenameIndex(table: "dbo.EmployeeSkill", name: "IX_EmployeeID", newName: "IX_Employee_ID");
            RenameColumn(table: "dbo.EmployeeSkill", name: "SkillID", newName: "Skill_ID");
            RenameColumn(table: "dbo.EmployeeSkill", name: "EmployeeID", newName: "Employee_ID");
            RenameTable(name: "dbo.EmployeeSkill", newName: "EmployeeSkills");
        }
    }
}
