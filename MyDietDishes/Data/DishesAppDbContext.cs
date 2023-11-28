using Microsoft.EntityFrameworkCore;
using MyDietDishes.Entities;

namespace MyDietDishes.Data
{
    public class DishesAppDbContext : DbContext
    {
        public DbSet<Meal> Meals => Set<Meal>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseInMemoryDatabase("StorageAppDb");
        }
    }
}
