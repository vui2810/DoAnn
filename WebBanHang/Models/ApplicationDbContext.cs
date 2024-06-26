using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace WebBanHang.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
        }
        public DbSet<Category> Categories { set; get; }
        public DbSet<Product> Products { set; get; }
        public DbSet<Order> Orders { set; get; }
        public DbSet<OrderDetail> OrderDetails { set; get; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //seed data to table Categories
            modelBuilder.Entity<Category>().HasData(
            new Category { Id = 1, Name = "Yamaha", DisplayOrder = 1 },
            new Category { Id = 2, Name = "Piaggio", DisplayOrder = 2 },
            new Category { Id = 3, Name = "Honda", DisplayOrder = 3 });
            //seed data to table Product
            modelBuilder.Entity<Product>().HasData(
            new Product { Id = 1, Name = "SH350i", Price = 300, CategoryId = 1 },
            new Product { Id = 2, Name = "SH160i/125i", Price = 350, CategoryId = 1 },
            new Product { Id = 3, Name = "Sh Mode 125", Price = 400, CategoryId = 1 },
            new Product { Id = 4, Name = "Vario 160", Price = 420, CategoryId = 1 },
            new Product { Id = 5, Name = "Air Blade 2025", Price = 630, CategoryId = 1 },
            new Product { Id = 6, Name = "Vario 125", Price = 750, CategoryId = 1 },
            new Product { Id = 7, Name = "LEAD 125", Price = 820, CategoryId = 1 },
            new Product { Id = 8, Name = "Vision Phiên Bản C", Price = 950, CategoryId = 1 },
            new Product { Id = 9, Name = "Super Cub C125", Price = 1200, CategoryId = 1 },
            new Product { Id = 10, Name = "Future 125 FI ", Price = 1450, CategoryId = 1 },
            new Product { Id = 11, Name = "Blade 2023", Price = 750, CategoryId = 2 },
            new Product { Id = 12, Name = "Wave Alpha 110", Price = 1250, CategoryId = 2 });
        }


    }
}
