using CarRentalSystem.Core.Entities.Concrete;
using CarRentalSystem.DataAccess.Concrete.EntityFramework.Mappings;
using CarRentalSystem.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRentalSystem.DataAccess.Concrete.EntityFramework
{
    public class CarRentalDbContext : DbContext
    {
        DbSet<Brand> Brands { get; set; }
        DbSet<Car> Cars { get; set; }
        DbSet<CarImage> CarImages { get; set; }
        DbSet<Color> Colors { get; set; }
        DbSet<Customer> Customers { get; set; }
        DbSet<Rental> Rentals { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<Core.Entities.Concrete.User> Users { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
        public CarRentalDbContext() { }
        public CarRentalDbContext(DbContextOptions<CarRentalDbContext> options) : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-UB2I2JK\\SQLEXPRESS;Initial Catalog=CarRentalDb;Integrated Security=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new CustomerMap());

        }
    }
}
