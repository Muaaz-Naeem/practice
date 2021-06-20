using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Empty.Models
{
    public class School
    {
        public static List<Section> sections = 
            new List<Section> { 
                new Section { ID = 1,Name="One" } ,
                new Section { ID = 2,Name="Two" },
                new Section { ID = 3,Name="Three" }
            };   
    }
}