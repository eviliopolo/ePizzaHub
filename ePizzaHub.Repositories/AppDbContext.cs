using ePizzaHub.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace ePizzaHub.Repositories
{
    public class AppDbContext : IdentityDbContext<User, Role, int>
    {
        //needed for migration
        public AppDbContext()
        {

        }
        //configuration from settings
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<ItemType> ItemTypes { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<PaymentDetails> PaymentDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //needed for migration
            if (!optionsBuilder.IsConfigured)
            {
                //optionsBuilder.UseSqlServer(@"data source=Shailendra\SqlExpress; initial catalog=ePizzaHubSite;integrated security=True;");

                optionsBuilder.UseSqlServer(@"Server=tcp:powerverse.database.windows.net,1433;Database=PowerVerseDB;Persist Security Info=False;User ID=welcomedly;Password=tW#gA%N@Fboq;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30");
            }
            base.OnConfiguring(optionsBuilder);
        }
    }
}
