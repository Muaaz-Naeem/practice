using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Empty.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }


        public string Email { get; set; }
        public string Address { get; set; }

        public string Biography { get; set; }

        public List<Skill> Skills { get; set; }

    }
}