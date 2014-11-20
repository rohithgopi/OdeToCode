//using OdeToFood.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.Helpers;
//using System.Web.Mvc;

//namespace OdeToFood.Controllers
//{
//    public class ReviewController : Controller
//    {
//        // GET: Review
//        public ActionResult Index()
//        {
//            return View();
//        }

//        public ActionResult GetData()
//        {
//            var serializer = new System.Web.Script.Serialization.JavaScriptSerializer();

//            return Json(_restaurantReview, JsonRequestBehavior.AllowGet);
//        }

//        // GET: Review/Details/5
//        public ActionResult Details(int id)
//        {
//            return View();
//        }

//        // GET: Review/Create
//        public ActionResult Create()
//        {
//            return View();
//        }

//        // POST: Review/Create
//        [HttpPost]
//        public ActionResult Create(FormCollection collection)
//        {
//            try
//            {
//                // TODO: Add insert logic here

//                return RedirectToAction("Index");
//            }
//            catch
//            {
//                return View();
//            }
//        }

//        // GET: Review/Edit/5
//        public ActionResult Edit(int id)
//        {
//            return View();
//        }

//        // POST: Review/Edit/5
//        [HttpPost]
//        public ActionResult Edit(int id, FormCollection collection)
//        {
//            try
//            {
//                // TODO: Add update logic here

//                return RedirectToAction("Index");
//            }
//            catch
//            {
//                return View();
//            }
//        }

//        // GET: Review/Delete/5
//        public ActionResult Delete(int id)
//        {
//            return View();
//        }

//        // POST: Review/Delete/5
//        [HttpPost]
//        public ActionResult Delete(int id, FormCollection collection)
//        {
//            try
//            {
//                // TODO: Add delete logic here

//                return RedirectToAction("Index");
//            }
//            catch
//            {
//                return View();
//            }
//        }

//        static List<ReviewModel> _restaurantReview = new List<ReviewModel>
//        {
//            new ReviewModel{RestaurantName = "Rest1", Comment="Great" ,Rating=9},
//            new ReviewModel{RestaurantName = "Rest2", Comment="Awesome" ,Rating=10},
//            new ReviewModel{RestaurantName = "Rest3", Comment="Nice" ,Rating=8},
//            new ReviewModel{RestaurantName = "Rest4", Comment="Bad" ,Rating=3},
//            new ReviewModel{RestaurantName = "Rest5", Comment="Yuk" ,Rating=1},
//            new ReviewModel{RestaurantName = "Rest6", Comment="OK" ,Rating=4}
//        };
//    }
//}
