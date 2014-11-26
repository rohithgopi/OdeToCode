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
        public ActionResult Index(string searchTerm=null)
        {
            var model = _db.Restaurants
                .Where(x => searchTerm == null || x.Name.StartsWith(searchTerm))
                .OrderByDescending(x => x.Reviews.Count)
                .Select(x => new RestaurantListView { Id = x.Id,
                Name = x.Name,
                City =x.City,
                Country = x.Country,
                ReviewCount = x.Reviews.Count});
            return View(model);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Restaurant restaurant)
        {
            
            //if (Request.Files["files"] != null)
            //{
            //    byte[] Image;
            //    using (var binaryReader = new BinaryReader(Request.Files["files"].InputStream))
            //    {
            //        Image = binaryReader.ReadBytes(Request.Files["files"].ContentLength);
            //    }
            //    restaurant.Photo = Image;
            //}
            
            //_db.Restaurants.Add(restaurant);
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