using POS.BL;
using POS.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace POS.MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Customers(IEnumerable<Customer> customers)
        {
            using (var context = new POSContext())
            {
                var customersList = context.Customers.ToList();
                return View(customersList);
            }  
        }
    }
}