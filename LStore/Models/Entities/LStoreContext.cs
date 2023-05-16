using Microsoft.EntityFrameworkCore;
using System.Data;

namespace LStore.Models.Entities
{
    public class LStoreContext : DbContext
    {
        public LStoreContext(DbContextOptions<LStoreContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // использование Fluent API
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<UserLogin> UserLogins { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<Product> Products { get; set; }

    }
}
