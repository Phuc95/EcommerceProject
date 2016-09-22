using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EcommerceProject.ViewModel
{
    public class UserRegister
    {
        public int UserID { get; set; }
        [Required(ErrorMessage = "Please enter an username")]
        [MaxLength(20, ErrorMessage = "Username can have maximum 20 characters")]
        [Display(Name = "User name")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Please enter password")]
        [DataType(DataType.Password)]
        [MinLength(6, ErrorMessage ="Password must have at least 6 character")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Please confirm password")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [System.Web.Mvc.Compare("Password", ErrorMessage = "Password does not match")]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage = "Please enter your email address")]
        [EmailAddress(ErrorMessage = "Email address is not valid")]
        [MaxLength(50, ErrorMessage ="Email can have maximum 50 characters")]
        public string Email { get; set; }

    }

    public class UserLogin
    {
        [Required(ErrorMessage = "Please enter your email address")]
        [EmailAddress(ErrorMessage = "Email address is not valid")]
        [MaxLength(50, ErrorMessage = "Email can have maximum 50 characters")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}