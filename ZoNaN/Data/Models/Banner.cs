using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ZoNaN.Models
{
    public class Banner
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Content { get; set; }
        public string Link { get; set; }
        public string Photo { get; set; }
        public bool IsMain { get; set; }
        public bool IsPromo { get; set; }
        public bool IsDiscount { get; set; }
        [NotMapped]
        public IFormFile Upload { get; set; }
    }
}
