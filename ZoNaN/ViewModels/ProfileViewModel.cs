using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZoNaN.Data.Models;
using ZoNaN.Models;

namespace ZoNaN.ViewModels
{
    public class ProfileViewModel
    {
        public Breadcrumb Breadcrumb { get; set; }
        public Subscriber Subscriber { get; set; }
        public CustomerLoginViewModel Customer { get; set; }
        public Customer Profile { get; set; }
        public List<Chekout> Chekouts { get; set; }

    }
}
