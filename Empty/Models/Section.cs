using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Empty.Models
{
    public class Section
    {
        public int ID { get; set; }
        public String Name { get; set; }

        public static List<Student> students = new List<Student> { new Student { ID = 1, Name = "Muaaz" },
      new Student { ID = 2, Name = "Waqas" },
      new Student { ID = 3, Name = "Abdullah" }
        };  
    

    }
}