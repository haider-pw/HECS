using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eCommerce.Web.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        public string Index()
        {
            return "Hello from the Store.Index()";         
        }                                                  
        public string Browse()                             
        {                                                  
            return "Hello from the Store.Browse";          
        }                                                  
        public string Details()                            
        {
            return "Hello from the Store.Details";
        }
    }
}