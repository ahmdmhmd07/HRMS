using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HRMS.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }



        [Required(ErrorMessage = "Please enter the full name!")]
        [DisplayName("Full Name")]
        public string FullName { get; set; }

    

        [Required(ErrorMessage = "Please enter the location!")]
        [DisplayName("Address")]
        public string Address { get; set; }

         

        [Required(ErrorMessage = "Please enter mobile number!")]
        [RegularExpression(@"^([0-9]{11})$", ErrorMessage = "Invalid Mobile Number.")]
        public string MobileNumber { get; set; }



        [Required(ErrorMessage = "Please enter the gender!")]
        public string Gender { get; set; }

        

        [Required(ErrorMessage = "Please enter the Nationality!")]
        public string Nationality { get; set; }



        [Required(ErrorMessage = "Please enter the date of birth!")]
        public DateTime BirthDate { get; set; }



        [Required(ErrorMessage = "Please enter the national id!")]
        [RegularExpression(@"^([0-9]{14})$", ErrorMessage = "Invalid National Number.")]
        public int NatId { get; set; }



        [Required(ErrorMessage = "Please enter the hiring date!")]
        public DateTime HiringDate { get; set; }



        [Required(ErrorMessage = "Please enter the salary!")]
        [RegularExpression(@"^$", ErrorMessage = "Invalid Slary.")]
        public double Salary { get; set; }



        public DateTime AttendTime { get; set; }
        public DateTime LeaveTime { get; set; }


    }
}
