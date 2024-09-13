using Microsoft.EntityFrameworkCore;
using WebApplication3.Models;

namespace WebApplication3.Context
{
    public class ApplicationDbContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-0ATCHFR\\MMSQL;Database=project;Trusted_Connection=True;Encrypt=false");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var _Category = new List<Category>
            {
                new Category { CategoryId = 1, Name = "Electronics", Description = "Devices and gadgets" },

                new Category { CategoryId = 2, Name = "Books", Description = "Reading materials" },

            };

            var _Product = new List<Product>
            {
               new Product { ProductId = 1, Title = "Laptop", Price = 1000, Description = "High performance laptop", Quantity = 10, CategoryId = 1 },
                new Product { ProductId = 2, Title = "Smartphone", Price = 600, Description = "Latest model", Quantity = 20, CategoryId = 1 }

            };
            var _Users = new List<User>
            {


                new User { UserId = 1, FirstName = "John", LastName = "Doe", Email = "john.doe@example.com", Password = "hashed_password_1" },
                new User { UserId = 2, FirstName = "Jane", LastName = "Smith", Email = "jane.smith@example.com", Password = "hashed_password_2" },
               new User { UserId = 3, FirstName = "Alice", LastName = "Johnson", Email = "alice.johnson@example.com", Password = "hashed_password_3" },


            };
            modelBuilder.Entity<Category>().HasData(_Category);
            modelBuilder.Entity<Product>().HasData(_Product);
            modelBuilder.Entity<User>().HasData(_Users);
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Category> Categories { get; set; }

    }
}
