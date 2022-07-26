using System;

namespace Best_Restaurants.Models
{
     public class Review
  {
    public int ReviewId { get; set; }
    public string Description { get; set; }
    public int CuisineId { get; set; }
    public virtual Cuisine Cuisine { get; set; }
    public virtual ICollection<Restaurant> Restaurants { get; set; }
  }
}