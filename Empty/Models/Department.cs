using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Empty.Models
{
    public class Department
    {
        public static List<Employee> employees = new List<Employee> {
            new Employee { ID=1,Name="Muaaz",Address="Dummy Address 1" } ,
            new Employee { ID=2,Name="Waqas",Address="Dummy Address 2"} ,
            new Employee { ID=3,Name="Abdullah",Address="Dummy Address 3"} ,
            new Employee { ID=4,Name="Zaid",Address="Dummy Address 4"} ,
        };


    }
}