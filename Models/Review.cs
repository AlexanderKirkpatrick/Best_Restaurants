using System;
using System.Collections.Generic;

namespace Best_Restaurants.Models
{
     public class Review
  {
    public Review()
    {
      this.Restaurants = new HashSet<Restaurant>();
    }

    public int ReviewId { get; set; }
    public string Description { get; set; }
    public int RestaurantId { get; set; }
    public int CuisineId { get; set; }
    public virtual Cuisine Cuisine { get; set; }
    public virtual Restaurant Restaurant { get; set; }
    public virtual ICollection<Restaurant> Restaurants { get; set; }
  }
}