using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace MvcValidation.Models
{
    public class Employee
    {
        [Required(ErrorMessage = "Please Enter Name.")]
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please Enter Email.")]
        [Display(Name = "Email")]
        [RegularExpression(@"^([a-zA-Z0-9_\.\-])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})+$", ErrorMessage = "Please enter correct email address.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please Enter Mbile No.")]
        [Display(Name = "Mobile")]
        [StringLength(10, ErrorMessage = "Mobile no must contain 10 digt.", MinimumLength = 10)]
        public string Mobile { get; set; }

    }
}