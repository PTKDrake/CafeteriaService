using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace CafeteriaService.Models
{
    public class CafeteriaDbContextFactory : IDesignTimeDbContextFactory<CafeteriaDbContext>
    {
        public CafeteriaDbContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder contextOptionsBuilder = new DbContextOptionsBuilder();
            contextOptionsBuilder.UseSqlServer(
                "Data Source=PTKDRAKE-PC;Initial Catalog=Cafeteria;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False;MultipleActiveResultSets=true");
            contextOptionsBuilder.LogTo(action =>
            {
                System.Diagnostics.Debug.WriteLine(action);
            });
            return new CafeteriaDbContext(contextOptionsBuilder.Options);
        }
    }

    public class CafeteriaDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }

        public DbSet<Item> Items { get; set; }

        public DbSet<Permission> Permissions { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderDetail> OrderDetails { get; set; }

        public List<CartItem> CartItems { get; set; } = new List<CartItem>();

        public List<Cart> Carts { get; set; } = new List<Cart>();

        public CafeteriaDbContext(DbContextOptions contextOptions) : base(contextOptions)
        {
        }

        public override int SaveChanges()
        {
            var entries = ChangeTracker
                .Entries()
                .Where(e => e.Entity is BaseEntity && (
                    e.State == EntityState.Added
                    || e.State == EntityState.Modified));

            foreach (var entityEntry in entries)
            {
                ((BaseEntity)entityEntry.Entity).UpdatedAt = DateTime.Now;

                if (entityEntry.State == EntityState.Added)
                {
                    ((BaseEntity)entityEntry.Entity).CreatedAt = DateTime.Now;
                }
            }

            return base.SaveChanges();
        }
    }

    public class BaseEntity
    {
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set;}
    }
}