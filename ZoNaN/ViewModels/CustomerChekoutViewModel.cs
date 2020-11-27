using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ZoNaN.ViewModels
{
    public class CustomerChekoutViewModel
    {
        [Required(ErrorMessage = "Please enter you  City")]
        [MaxLength(50)]
        public string City { get; set; }
        [Required(ErrorMessage = "Please enter you Address")]
        [MaxLength(50)]
        public string Address { get; set; }
        [Required(ErrorMessage = "Please enter you Payment Method")]
        [MaxLength(50)]
        public string PaymentMethod { get; set; }
        [Required(ErrorMessage = "Please enter your agreement")]
        public string Agreement { get; set; }
        public bool Shipping { get; set; }
        public string Message { get; set; }
    }
}
