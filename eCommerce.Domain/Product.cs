using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Domain
{
    public class Product
    {
        public virtual int ProductID { get; set; }
        public virtual string Model { get; set; }
        public virtual int CategoryID { get; set; }
    }
}
