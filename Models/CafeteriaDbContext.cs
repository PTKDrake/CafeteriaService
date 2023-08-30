using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeteriaService.Models
{
    public class CafeteriaDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }

        public DbSet<Image> Images { get; set; }

        public DbSet<Item> Items { get; set; }

        public DbSet<Permission> Permissions { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderDetail> OrderDetails { get; set; }

        public List<CartItem> CartItems { get; set; } = new List<CartItem>();

        public List<Cart> Carts { get; set; } = new List<Cart>();
        
        public CafeteriaDbContext() : base("CafeteriaConnectionString")
        {
        }
    }
}