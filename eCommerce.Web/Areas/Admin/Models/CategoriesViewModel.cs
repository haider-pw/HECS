using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eCommerce.Web.Areas.Admin.Models
{
    public class CategoriesViewModel
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public ICollection<ProductViewModel> Products { get; set; }
    }
}