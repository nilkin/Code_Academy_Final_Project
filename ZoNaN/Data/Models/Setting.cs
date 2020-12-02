using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZoNaN.Models
{
    public class Setting
    {
        public int Id { get; set; }
        public string Logo { get; set; }
        public string Info { get; set; }
        [NotMapped]
        public IFormFile Upload { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
    }
}
