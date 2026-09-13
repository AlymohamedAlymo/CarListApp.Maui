using Microsoft.EntityFrameworkCore;

namespace CarListApp.Api
{
    public class CarListDbContext : DbContext
    {
        public CarListDbContext(DbContextOptions<CarListDbContext> options) : base(options)
        {
        }
        public DbSet<Car> Cars { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Car>().HasData(
                new Car { Id = 1, Make = "Toyota", Model = "Camry", Vin = "1234567890" },
                new Car { Id = 2, Make = "Honda", Model = "Civic", Vin = "0987654321" },
                new Car { Id = 3, Make = "Ford", Model = "Mustang", Vin = "5678901234" },
                new Car { Id = 4, Make = "BMW", Model = "3 Series", Vin = "LLLFY2M0Y8XUC9WPW" },
                new Car { Id = 5, Make = "Nissan", Model = "Altima", Vin = "V61PMGG7AEJW9ZT8D" },
                new Car { Id = 6, Make = "Audi", Model = "A4", Vin = "4EE57GJKBAUTKG9LH" },
                new Car { Id = 7, Make = "Ford", Model = "F-150", Vin = "1FTFW1ED5MFA12345" },
                new Car { Id = 8, Make = "Chevrolet", Model = "Silverado", Vin = "1GCEKEDC0LF543210" },
                new Car { Id = 9, Make = "Hyundai", Model = "Elantra", Vin = "5NPDH4AE7LH987654" },
                new Car { Id = 10, Make = "Jeep", Model = "Wrangler", Vin = "1C4HJXDG0LW135792" }
            );
        }

    }
}