using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace UserRegistrationAPI.Models
{
    public class Register
    {
        [Required(ErrorMessage ="Please enter First name.")]
        [Display(Name ="First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter Last name.")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter Email.")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter Password.")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Pwd { get; set; }

        [Required(ErrorMessage = "Please enter Confirm Password.")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("Pwd")]
        public string ConPwd { get; set; }
    }
}