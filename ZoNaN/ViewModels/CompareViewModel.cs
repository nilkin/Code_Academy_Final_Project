using System.Collections.Generic;
using ZoNaN.Data;
using ZoNaN.Data.Models;
using ZoNaN.Models;

namespace ZoNaN.ViewModels
{
    public class CompareViewModel
    {
        public Breadcrumb Breadcrumb { get; set; }
        public List<CompareItem> CompareItems { get; set; }
        public Subscriber Subscriber { get; set; }
        public List<CompareItem> CmprItems { get; internal set; }
    }
}
