using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ShoppingDBContext:DbContext
    {
        public ShoppingDBContext(DbContextOptions opt):base(opt)
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogCategory> BlogCategories { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<ProductPicture> ProductPictures { get; set; }
        public DbSet<MyConfiguration> MyConfigurations{ get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Category>().HasData(
            new Category {Id=1, Name = "Silver Dangle" },
            new Category {Id=2, Name = "Earrings" },
            new Category {Id=3, Name = "Necklace" }
            );
            builder.Entity<Product>().HasData(
            new Product { 
                Id=1,
                Name = "Silver Dangle 1",
                Price=2500,
                IsFeatured=false,
                CategoryId=1,
                IsComplect=false
            },
            new Product
            {
                Id=2,
                Name = "Silver Dangle 2",
                Price = 2500,
                Discount=2200,
                IsFeatured = true,
                CategoryId = 2,
                IsComplect = true
            }
            );
        }

    }
}
