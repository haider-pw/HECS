using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Domain
{
    public class Category
    {
        public virtual int CategoryID { get; set;}
        public virtual string CategoryName { get; set; }
        public ICollection<Product> CategoryProducts { get; set; }       
    }
}
