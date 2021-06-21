using Empty.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Empty.ViewModels
{
    public class EmployeeViewModel
    {
        //commit from main 
        public EmployeeViewModel()
        {
         //    employees = new List<Employee>();
        }
        public List<Employee> employees { get; set; }
    }
}