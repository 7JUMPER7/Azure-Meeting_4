using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Meeting_26.Models
{
    public class CarsContext : DbContext
    {
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<Car> Cars { get; set; }

        public CarsContext(DbContextOptions<CarsContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Manufacturer>().HasData(
                new Manufacturer { Id = 1, Name = "Tesla" }
                );
            builder.Entity<Car>().HasData(
                new Car { Id = 1, ManufacturerId = 1, Name = "Model 3 Performance", Year = 2021, Price = 55000, Color = "Blue" },
                new Car { Id = 2, ManufacturerId = 1, Name = "Model S Plaid", Year = 2022, Price = 145000, Color = "Black" },
                new Car { Id = 3, ManufacturerId = 1, Name = "Model X Plaid", Year = 2022, Price = 155000, Color = "White" }
                );
        }
    }
}
