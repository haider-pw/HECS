using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using eCommerce.Domain;

namespace eCommerce.Web.Infrastructure
{
    public class CategoryDb : DbContext, ICategoriesDataSource
    {
        public CategoryDb() : base("DefaultConnection"){

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        IQueryable<Category> ICategoriesDataSource.Categories
        {
            get { return Categories; }
        }

        IQueryable<Product> ICategoriesDataSource.Products
        {
            get { return Products; }
        }
    }
}