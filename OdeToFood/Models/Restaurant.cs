using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OdeToFood.Models
{
    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        //public string Description { get; set; }
        //public byte[] Photo { get; set; }
        public virtual ICollection<RestaurantReview> Reviews { get; set; }
    }
}