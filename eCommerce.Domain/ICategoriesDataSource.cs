using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Domain
{
    public interface ICategoriesDataSource
    {
        IQueryable<Category> Categories { get; }
        IQueryable<Product> Products { get; }
    }
}
