using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZoNaN.Data.Models;

namespace ZoNaN.ViewModels
{
    public class ChekoutViewModel
    {
        public Breadcrumb Breadcrumb { get; set; }
        public Subscriber Subscriber { get; set; }
        public ChekPayViewModel ChekPay { get; set; }
    }
}
