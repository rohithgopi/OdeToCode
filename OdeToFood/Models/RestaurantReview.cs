using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OdeToFood.Models
{
    public class RestaurantReview
    {
        public int Id { get; set; }
        [Required]
        [Range(1,10)]
        public string Rating { get; set; }
        [Required]
        [MaxLength(1024)]
        [MinLength(6)]
        public string Comment { get; set; }
        
        public string ReviewerName { get; set; }
        public int RestaurantId { get; set; }
    }
}