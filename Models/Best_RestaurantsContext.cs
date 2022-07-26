using Microsoft.EntityFrameworkCore;

namespace Best_Restaurants.Models
{
  public class Best_RestaurantsContext : DbContext
  {
    public DbSet<Cuisine> Cuisines { get; set; }
    public DbSet<Restaurant> Restaurants { get; set; }

    public Best_RestaurantsContext(DbContextOptions options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
    optionsBuilder.UseLazyLoadingProxies();
    }
  }
}