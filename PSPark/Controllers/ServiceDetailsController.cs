using PSPark.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PSPark.Controllers
{
    public class ServiceDetailsController : Controller
    {
        private ApplicationDbContext _context = new ApplicationDbContext();

        // GET: ServiceDetails
        public ActionResult Index()
        {
            return View(_context.serviceDetails.ToList());
        }
    }
}