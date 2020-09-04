using PSPark.Models;
using PSPark.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PSPark.Controllers
{
    public class AddServicesController : Controller
    {
        private ApplicationDbContext _context = new ApplicationDbContext();


        // GET: AddServices
        public ActionResult Index()
        {
            var a = _context.addServices.ToList();
            var b = new NewViewModel
                { AddServices = a };

            return View(b);


        }

        public ActionResult New()
        {
            return View();
        }

}
}