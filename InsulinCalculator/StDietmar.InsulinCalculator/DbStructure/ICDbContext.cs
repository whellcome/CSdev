using System;
using System.Data.Entity;

namespace StDietmar.InsulinCalculator.DbStructure
{
    public class ICDbContext : DbContext
    {
        public ICDbContext()
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Dish> Dishes { get; set; }
    }
}
