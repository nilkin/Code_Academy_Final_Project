using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using ZoNaN.Models;

namespace ZoNaN.ViewModels
{
    public class ChekPayViewModel
    {
        public int? CustomerId { get; set; }
        public string Gender { get; set; }
        [Required(ErrorMessage = "Please enter you Name")]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter you Email")]
        [MaxLength(50)]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Please enter you Surname")]
        [MaxLength(50)]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter you  City")]
        [MaxLength(50)]
        public string City { get; set; }
        [Required(ErrorMessage = "Please enter you destination Address")]
        [MaxLength(50)]
        public string Address { get; set; }
        [Required(ErrorMessage = "Please enter you destination Address")]
        [MaxLength(50)]
        public string Mobile { get; set; }
        public string PaymentMethod { get; set; }
        public bool Payment { get; set; }
        public bool Shipping { get; set; }
        public string Message { get; set; }
       
    }
}
