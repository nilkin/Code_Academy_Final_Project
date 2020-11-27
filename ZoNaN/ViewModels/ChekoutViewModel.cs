using ZoNaN.Data.Models;
using ZoNaN.Models;

namespace ZoNaN.ViewModels
{
    public class ChekoutViewModel
    {
        public Breadcrumb Breadcrumb { get; set; }
        public Subscriber Subscriber { get; set; }
        public ChekPayViewModel ChekPay { get; set; }
        public CustomerChekoutViewModel CustomerChekout { get; set; }
        public Customer TokenUser { get; set; }
    }
}
