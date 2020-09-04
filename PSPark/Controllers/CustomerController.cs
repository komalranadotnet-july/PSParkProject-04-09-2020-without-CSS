using System;
using PSPark.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using System.Data.Entity;

namespace PSPark.Controllers
{
    public class CustomerController : Controller
    {
        private ApplicationDbContext _context = new ApplicationDbContext();
        // GET: Customer
        public ActionResult Index()
        {

        return View(_context.customers.ToList());

        }


        public ActionResult Edit(int id)
        {

            var updateCustomer = _context.customers.Find(id);
            if (updateCustomer == null)
            {
                return HttpNotFound();
            }

            var m = updateCustomer;

            _context.SaveChanges();

            return View("New", m);
        }


      public ActionResult New()
        {


            return View();
        }

    public ActionResult Save(Customer customer)
        {

            if (customer.Id == 0)
                _context.customers.Add(customer);

            else
            {
                var customerInDb = _context.customers.Single(c => c.Id == customer.Id);
                customerInDb.Name = customer.Name;
                customerInDb.PhoneNo = customer.PhoneNo;
                customerInDb.Email = customer.Email;


            }
            _context.SaveChanges();
            return RedirectToAction("Index", "Customer");
        }

         public ActionResult Delete(int id)
        {
            Customer obj = _context.customers.Find(id);
            _context.customers.Remove(obj);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}