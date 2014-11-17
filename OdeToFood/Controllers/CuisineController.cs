using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood.Controllers
{
    public class CuisineController : Controller
    {
        // GET: Cuisine
        [Authorize]
        public ActionResult Search(string name)
        {
            return Content("This is a message");
            //return RedirectToRoute("Default", new { controller = "Cuisine", action = "Redirect" });
        }

        //public ActionResult Search()
        //{
        //    return Content("Search!");
        //}
    }
}