using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OdeToFood.Models
{
    public class OdeToFoodDb : DbContext
    {
        public OdeToFoodDb()
            : base("name=OdeToFoodConn")
        {
                
        }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<RestaurantReview> Reviews { get; set; }

    }

    abstract class sample
    { 
    
    }

    public class Sample2
    {
        public virtual void Hello()
        {
            string X = "Hello";
        }
    }

    public class Sample3 : Sample2
    {
        static string u;
        static Sample3()
        {
            u = "hellol";
        }
        public Sample3()
        {
            u = "hello2";
        }
        public override void Hello()
        {
            u = "hello3";
        }
    }
}