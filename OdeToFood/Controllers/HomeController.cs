using OdeToFood.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood.Controllers
{
    public class HomeController : Controller
    {
        OdeToFoodDb _db = new OdeToFoodDb();
        public ActionResult Index()
        {
            var model = _db.Restaurants;
            return View(model);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Restaurant restaurant)
        {
            if (Request.Files["files"] != null)
            {
                byte[] Image;
                using (var binaryReader = new BinaryReader(Request.Files["files"].InputStream))
                {
                    Image = binaryReader.ReadBytes(Request.Files["files"].ContentLength);
                }
            }
            
            _db.Restaurants.Add(restaurant);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult About()
        {
            AboutModel about = new AboutModel();
            about.Name = "Rohith Gopi";
            about.Location = "Bangalore";

            return View(about);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        protected override void Dispose(bool disposing)
        {
            if (_db != null)
                _db.Dispose();
            base.Dispose(disposing);
        }
    }
}