using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ZoNaN.Models
{
    public class Review
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter Fullname")]
        [MaxLength(50)]
        public string Fullname { get; set; }
        [Required(ErrorMessage = "Please enter Email Address")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public string Message { get; set; }
        public byte Rate { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public DateTime AddedDate { get; set; }
    }
}