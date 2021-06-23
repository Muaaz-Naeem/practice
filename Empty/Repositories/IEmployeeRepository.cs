using Empty.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empty.Repositories
{
   public interface IEmployeeRepository
    {
       IEnumerable< Employee> GetEmployees();
        Employee GetEmployee(int id   );
    }
}
