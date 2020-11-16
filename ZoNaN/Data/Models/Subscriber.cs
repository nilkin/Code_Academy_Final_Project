using System.ComponentModel.DataAnnotations;

namespace ZoNaN.Data.Models
{
    public class Subscriber
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        [EmailAddress]
        public string Email { get; set; }
    }
}
