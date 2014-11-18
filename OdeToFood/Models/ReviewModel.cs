using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OdeToFood.Models
{
    public class ReviewModel
    {
        public string RestaurantName { get; set; }
        public string Comment { get; set; }
        public int Rating { get; set; }
    }
}