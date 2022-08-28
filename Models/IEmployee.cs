using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRMS.Models
{
   public interface IEmployee
    {
        Employee Find (int Id);
        IEnumerable<Employee> GetAllEmployees();
        Employee Add(Employee employee);
        Employee Update(int id,Employee employee);
        Employee Delete(int id);
    }
}
