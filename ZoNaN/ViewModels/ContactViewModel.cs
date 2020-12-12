using ZoNaN.Data.Models;
using ZoNaN.Models;

namespace ZoNaN.ViewModels
{
    public class ContactViewModel
    {
        public Breadcrumb Breadcrumb { get; set; }
        public Subscriber Subscriber { get; set; }
        public ContactUs Contact { get; set; }
        public Setting ContactWithUs { get; set; }
    }
}
