using HRMS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRMS.Models
{
    public class EmployeeRepo : IEmployee
    {


        //init ctor
        private readonly ApplicationDbContext db;
        public EmployeeRepo(ApplicationDbContext _db)
        {
            db = _db;
        }






        //Add
        public Employee Add(Employee employee)
        {
            db.Employees.Add(employee);
            db.SaveChanges();
            return employee;
        }



        //Delete
        public Employee Delete(int id)
        {
            var emp = db.Employees.SingleOrDefault(e => e.EmployeeID == id);
            db.Employees.Remove(emp);
            db.SaveChanges();
            return emp;
        }






        public IEnumerable<Employee> GetAllEmployees()
        {
            return db.Employees;
        }





        public Employee Find(int Id)
        {
            return db.Employees.Find(Id);
        }




        //update
        public Employee Update(int id,Employee empChange)
        {
            db.Employees.Update(empChange);
            db.SaveChanges();
            return empChange;
        }
    }
}
