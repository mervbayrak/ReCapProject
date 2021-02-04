﻿using CarRentalSystem.Entities.Concrete;
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
        DbSet<Color> Colors { get; set; }
        public CarRentalDbContext() { }
        public CarRentalDbContext(DbContextOptions<CarRentalDbContext> options) : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
            optionsBuilder.UseSqlServer("Data Source=YourserverName;Initial Catalog=CarRentalDb;Integrated Security=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }
}
