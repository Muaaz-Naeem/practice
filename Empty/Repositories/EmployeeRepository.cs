using Empty.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Unity;

namespace Empty.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        //public NextbridgeContext db = new NextbridgeContext();

        [Dependency]
        public NextbridgeContext db { get; set; }
        public Employee GetEmployee(int id)
        {
            return db.Employees.Find(id);
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return db.Employees.ToList(); 
        }
    }
}