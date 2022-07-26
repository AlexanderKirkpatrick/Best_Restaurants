using System;
using System.Collections.Generic;

namespace Best_Restaurants.Models
{
     public class Restaurant
  {
    public int RestaurantId { get; set; }
    public string Description { get; set; }
    public string Name { get; set; }
    public string Location { get; set; }
    public string Rating { get; set; }
    public int CuisineId { get; set; }
    public int ReviewId { get; set; }
    public virtual Cuisine Cuisine { get; set; }
  }
}