using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZoNaN.Models
{
    public class ProductPhoto
    {
        public int Id { get; set; }
        public bool IsFirstPhoto { get; set; }
        public bool IsSecondPhoto { get; set; }
        public string Photo { get; set; }
        [NotMapped]
        public IFormFile Upload { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }

    }
}