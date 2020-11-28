using System;
using System.ComponentModel.DataAnnotations;

namespace ZoNaN.ViewModels
{
    public class AccountDetailViewModel 
    {

        [Required(ErrorMessage = "Please Enter you Name")]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please Enter you Lastname")]
        [MaxLength(50)]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Please Enter you Email")]
        [MaxLength(50)]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please Enter you Birthdate")]
        [DataType(DataType.Date)]
        public DateTime Birthdate { get; set; }
        [Required(ErrorMessage = "Please enter you  City")]
        [MaxLength(50)]
        public string City { get; set; }
        [Required(ErrorMessage = "Please enter you Address")]
        [MaxLength(50)]
        public string Address { get; set; }
        [Required(ErrorMessage = "Please enter you Mobile")]
        [MaxLength(50)]
        public string Mobile { get; set; }
        [Required(ErrorMessage = "Please enter you Current Password")]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "Password cannot be longer than 100 characters and less than 6 characters")]
        public string CurrentPassword { get; set; }
        [StringLength(100, MinimumLength = 6, ErrorMessage = "Password cannot be longer than 100 characters and less than 6 characters")]
        [DataType(DataType.Password)]
        public string NewPassword { get; set; }
        [Compare("NewPassword")]
        [DataType(DataType.Password)]
        public string PasswordConfirm { get; set; }
    }
}
