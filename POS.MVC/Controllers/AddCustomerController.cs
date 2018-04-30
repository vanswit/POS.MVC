using POS.BL;
using POS.MVC;
using POS.MVC.Models;
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
            using (var context = new POSContext())
            {
                var viewModel = new ViewModel();
                viewModel.Addresses = context.Addresses.ToList();
                return View(viewModel);
            }
        }

        [HttpPost]
        public ActionResult Create(ViewModel model)
        {
            //if (ModelState.IsValid)
            //{
            //    using (var context = new POSContext())
            //    {
            //        var address = from c in context.Addresses
            //                      where c.Id == model.AddressId
            //                      select c;
            //        var customer = new Customer(model.Customer.LastName, model.Customer.FirstName, (Address)address, model.Customer.EmailAddress);
            //        context.Customers.Add(customer);
            //        context.SaveChanges();
            //        return RedirectToAction("Index");
            //    }
            //}
            using (var context = new POSContext())
            {
                var id = Convert.ToInt32(model.AddressId);
                var q = from c in context.Addresses
                              where c.Id == id
                              select c;

                
                var customer = new Customer(model.Customer.LastName, model.Customer.FirstName, (Address)q.First(), model.Customer.EmailAddress);
                context.Customers.Add(customer);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
        }
    }
}