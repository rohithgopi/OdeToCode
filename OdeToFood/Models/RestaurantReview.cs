using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OdeToFood.Models
{
    public class RestaurantReview
    {
        public int Id { get; set; }
        public string Rating { get; set; }
        public string Comment { get; set; }
        public int RestaurantId { get; set; }
    }
}