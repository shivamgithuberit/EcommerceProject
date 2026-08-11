using Microsoft.EntityFrameworkCore;
using EcommerceProject.Models;
using System.Collections.Generic;

namespace EcommerceProject.Data
{
    public class EcommerceDbContext : DbContext
    {

        public EcommerceDbContext(DbContextOptions<EcommerceDbContext> options) : base(options) { }



        public DbSet<Cart> Carts { get; set; } 
        public DbSet<CartItem> CartItems { get; set; }

        public DbSet<Category> Categeries { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderLine> OrderLines { get; set; }
        public DbSet<Picture> Pictures { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }





    }
}
