using Microsoft.EntityFrameworkCore;
using StoreSystem.Models;

namespace StoreSystem.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            
        }

        public DbSet<Item> items { get; set; }
        public DbSet<Store> stores { get; set; }
        public DbSet<StoreItem> soreItem { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Item>()
                        .Property(i => i.Price)
                        .HasColumnType("decimal(18, 2)");
            modelBuilder.Entity<Store>().HasData(
                new Store { Id = 1, Name = "Manshia Store", Address = "Ahmed Orabi Square",PhoneNumber="0123456789" },
                new Store { Id = 2, Name = "Sidi Gaber Store", Address = "Front of sidi Gaber Elsheikh tram station", PhoneNumber = "0123456789" }
                );
            modelBuilder.Entity<Item>().HasData(
                new Item { Id = 1, Name = "Samasung S24", Description = "Lorem Ipsum", Price = 2000 },
                new Item { Id = 2, Name = "Iphone 14", Description = "Lorem Ipsum", Price = 3000 }
                );
        }


    }
}
