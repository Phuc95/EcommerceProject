using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EcommerceProject.ViewModel
{
    public class OrderViewModel
    {
        [Required(ErrorMessage = "Please enter your full name")]
        [MaxLength(50, ErrorMessage = "Full name can have maximum 50 characters")]
        [Display(Name = "Full name")]
        public string Fullname { get; set; }
        [Required(ErrorMessage = "Please enter Shipping Address")]
        [MaxLength(50, ErrorMessage = "Address can have maximum 100 characters")]
        [Display(Name = "Shipping Address")]
        public string ShippingAddress { get; set; }
        [Required(ErrorMessage = "Please enter your email address")]
        [EmailAddress(ErrorMessage = "Email address is not valid")]
        [MaxLength(50, ErrorMessage = "Email can have maximum 50 characters")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Phone is Required")]
        [Display(Name = "PhoneNumber")]
        [RegularExpression(@"^0[0-9]{9,10}$", ErrorMessage = "Invalid Phone Number")]
        public string PhoneNumber { get; set; }
    }
}