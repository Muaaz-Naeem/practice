using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Empty.Models
{
    public class EmployeeSkills
    {

        
        public int EmployeeID { get; set; }
        public int SkillID { get; set; }

        public Skill Skill { get; set; }
        public Employee Employee { get; set; }
        public string Date { get; set; }

    }
}