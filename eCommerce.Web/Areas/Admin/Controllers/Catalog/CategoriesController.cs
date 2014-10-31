using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using eCommerce.Domain;
using eCommerce.Web.Infrastructure;

namespace eCommerce.Web.Areas.Admin.Controllers.Catalog
{
    public class CategoriesController : Controller
    {
        private ICategoriesDataSource _db;
        public CategoriesController(ICategoriesDataSource db)
        {
            _db = db;
        }
        // GET: Admin/Categories
        public ActionResult Index()
        {
            return View();
        }
    }

}
