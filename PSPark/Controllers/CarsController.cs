using PSPark.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PSPark.Controllers
{
    public class CarsController : Controller
    {
        private ApplicationDbContext _context = new ApplicationDbContext();

        // GET: Cars
        public ActionResult Index()
        {
            return View(_context.cars.ToList());
        }






        public ActionResult New()
        {


            return View();
        }

        public ActionResult Save(Cars cars)
        {

            if (cars.CarsId == 0)
                _context.cars.Add(cars);

            else
            {
                var carsInDb = _context.cars.Single(c => c.CarsId == cars.CarsId);
                carsInDb.Vin = cars.Vin;
                carsInDb.Make = cars.Make;
                carsInDb.Model = cars.Make;
                carsInDb.Style = cars.Style;
                carsInDb.MYear = cars.MYear;
                carsInDb.Color = cars.Color;


            }
            _context.SaveChanges();
            return RedirectToAction("Index", "Cars");
        }

        public ActionResult Delete(int id)
        {
            Cars obj = _context.cars.Find(id);
            _context.cars.Remove(obj);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }





    }
}