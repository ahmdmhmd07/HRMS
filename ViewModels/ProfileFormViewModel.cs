using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HRMS.ViewModels
{
    public class ProfileFormViewModel
    {

        public string Id { get; set; }


        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 3)]
        [DataType(DataType.Password)]
        [Display(Name = "FirstName")]
        public string FirstName { get; set; }



        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 3)]
        [DataType(DataType.Password)]
        [Display(Name = "LastName")]
        public string LastName { get; set; }




        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }



        [Required]
        [StringLength(100)]
        [DataType(DataType.Password)]
        [Display(Name = "Username")]
        public string UserName { get; set; }
    }
}
