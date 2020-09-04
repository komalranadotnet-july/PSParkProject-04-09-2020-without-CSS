using PSPark.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PSPark.Controllers
{
    public class ServiceHistoryController : Controller
    {
        private ApplicationDbContext _context = new ApplicationDbContext();

        // GET: ServiceHistory
        public ActionResult Index()
        {
            return View(_context.serviceHistories.ToList()) ;
        }













        public ActionResult New()
        {


            return View();
        }

        public ActionResult Save(ServiceHistory serviceHistory)
        {

            if (serviceHistory.Id == 0)
                _context.serviceHistories.Add(serviceHistory);

            else
            {
                var serviceHistoryInDb = _context.serviceHistories.Single(c => c.Id == serviceHistory.Id);
                serviceHistoryInDb.Miles = serviceHistory.Miles;
                serviceHistoryInDb.TotPrice = serviceHistory.TotPrice;
                serviceHistoryInDb.Details = serviceHistory.Details;
                serviceHistoryInDb.DateAdded = serviceHistory.DateAdded;



            }
            _context.SaveChanges();
            return RedirectToAction("Index", "ServiceHistory");
        }


        public ActionResult Delete(int id)
        {
            ServiceHistory obj = _context.serviceHistories.Find(id);
            _context.serviceHistories.Remove(obj);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}