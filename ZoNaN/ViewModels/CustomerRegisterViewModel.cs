﻿using System;
using System.ComponentModel.DataAnnotations;

namespace ZoNaN.ViewModels
{
    public class CustomerRegisterViewModel

    {
        [Required(ErrorMessage = "Required field")]
        [MaxLength(50)]
        public string Gender { get; set; }
        [Required(ErrorMessage = "Please Enter you Name")]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please Enter you Lastname")]
        [MaxLength(50)]
        public string Lastname { get; set; }
        [Required(ErrorMessage = "Please Enter you Email")]
        [MaxLength(50)]
        [EmailAddress]
        public string Email { get; set; }
        [StringLength(100, MinimumLength = 6, ErrorMessage = "Password cannot be longer than 100 characters and less than 6 characters")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage = "Please Enter you Birthdate")]
        [DataType(DataType.Date)]
        public DateTime Birthdate { get; set; }
        public bool IsSubscribe { get; set; }
    }
}
