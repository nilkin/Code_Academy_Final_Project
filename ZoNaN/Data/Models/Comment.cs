using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;
using ZoNaN.Models;

namespace ZoNaN.Data.Models
{
    public class Comment
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter Fullname")]
        [MaxLength(50)]
        public string Fullname { get; set; }
        [Required(ErrorMessage = "Please enter Email Address")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public string Website { get; set; }
        public string Photo { get; set; }
        [NotMapped]
        public IFormFile Upload { get; set; }
        public DateTime AddedDate { get; set; }
        public int BlogId { get; set; }
        public Blog Blog { get; set; }
    }
}
