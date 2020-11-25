using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ZoNaN.ViewModels
{
    public class CustomerLoginViewModel
    {
        [Required]
        [MaxLength(50)]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please Enter you Password")]
        [DataType(DataType.Password)]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "Password cannot be longer than 100 characters and less than 6 characters")]
        public string Password { get; set; }
        [MaxLength(100)]
        public string Token { get; set; }
    }
}
