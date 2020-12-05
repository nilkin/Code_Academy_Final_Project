using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ZoNaN.Data.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Token { get; set; }
        public string Photo { get; set; }
        [NotMapped]
        public IFormFile Upload { get; set; }
        public string Position { get; set; }

    }
}
