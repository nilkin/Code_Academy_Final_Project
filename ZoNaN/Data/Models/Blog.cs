using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using ZoNaN.Data.Models;

namespace ZoNaN.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Subject { get; set; }
        public bool IsNew { get; set; }
        public DateTime Date { get; set; }
        public string Text { get; set; }
        public string Photo { get; set; }
        [NotMapped]
        public IFormFile Upload { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
