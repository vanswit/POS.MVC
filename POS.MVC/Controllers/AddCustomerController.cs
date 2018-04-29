using POS.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace POS.MVC.Controllers
{
    public class AddCustomerController : Controller
    {
        // GET: AddCustomer
        public ActionResult Index()
        {
            return View();
        }

        
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Customer customer)
        {
            return View();
        }
    }
}