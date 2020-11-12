using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ZoNaN.Data.Models
{
    public class Breadcrumb
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Photo { get; set; }
        [NotMapped]
        public IFormFile Upload { get; set; }
        public string Link { get; set; }
        public string Path { get; set; }
        public bool IsProduct { get; set; }
        public bool IsProductSingle { get; set; }
        public bool IsAboutUs { get; set; }
        public bool IsLogin { get; set; }
        public bool IsProfile { get; set; }
        public bool IsRegister { get; set; }
        public bool IsChekout { get; set; }
        public bool IsBlog { get; set; }
        public bool IsBlogSingle { get; set; }
        public bool IsContact { get; set; }
        public bool IsCompare { get; set; }
        public bool IsCart { get; set; }
        public bool IsWish { get; set; }

    }
}
