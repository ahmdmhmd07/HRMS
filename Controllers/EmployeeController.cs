using HRMS.Data;
using HRMS.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRMS.Controllers
{
    public class EmployeeController : Controller
    {


        //init
        private readonly IEmployee  ie;
        public IWebHostEnvironment HostingEnvironment { get; }
        public EmployeeController (IEmployee  _ie, IWebHostEnvironment hostingEnvironment)
        {
            ie = _ie;
            HostingEnvironment = hostingEnvironment;
        }







        // GET: EmployeeController
        public ActionResult Index()
        {
            var model = ie.GetAllEmployees();
            return View(model);
        }





        // GET: EmployeeController/Details/5
        public ActionResult Details(int id)
        {
            var emps = ie.Find(id);
            return View(emps);
        }





        // GET: EmployeeController/Create
        public ActionResult Create()
        {
            return View();
        }



        // POST: EmployeeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Employee model)
        {
            if (ModelState.IsValid)
            {

                //string fileName = UploadFile(model.File) ?? string.Empty;
                Employee newEmployee = new Employee
                {
                    EmployeeID = model.EmployeeID,
                    FullName = model.FullName,
                    Address = model.Address,
                    Nationality = model.Nationality,
                    Gender = model.Gender,
                    BirthDate = model.BirthDate,
                    NatId = model.NatId,
                    MobileNumber = model.MobileNumber,
                    Salary = model.Salary,
                    HiringDate = model.HiringDate,
                    AttendTime = model.AttendTime,
                    LeaveTime = model.LeaveTime
                };

                ie.Add(newEmployee);
                return RedirectToAction("Details", new { id = newEmployee.EmployeeID });
            }

            return View();
        }






        //// GET: EmployeeController/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    var model = ie.Find(id);
        //    {
        //        EmployeeID = model.EmployeeID,
        //            FullName = model.FullName,
        //            Address = model.Address,
        //            Nationality = model.Nationality,
        //            Gender = model.Gender,
        //            BirthDate = model.BirthDate,
        //            NatId = model.NatId,
        //            MobileNumber = model.MobileNumber,
        //            Salary = model.Salary,
        //            HiringDate = model.HiringDate,
        //            AttendTime = model.AttendTime,
        //            LeaveTime = model.LeaveTime
        //        };
        //    return View(model);
        //}

        //// POST: EmployeeController/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}





        // GET: EmployeeController/Delete/5
        public ActionResult Delete(int id)
        {
            var emp = ie.Find(id);
            return View(emp);
        }


        // POST: EmployeeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                ie.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
