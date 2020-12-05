using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ZoNaN.Areas.Manager.ViewModels
{
    public class UserLoginViewModel
    {
        [DisplayName("Email")]
        [Required]
        [MaxLength(50)]
        [EmailAddress]
        public string Email { get; set; }

        [DisplayName("Password")]
        [Required]
        [MaxLength(100)]
        [DataType(DataType.Password)]
        [MinLength(6)]
        public string Password { get; set; }
    }
}
