using EF_Model.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_DataAccess.Data
{
    public class ApplicationDBContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Genre> Genres { get; set; }

        public DbSet<Author> Authors { get; set; }

        public DbSet<Publisher> Publishers { get; set; }

        public DbSet<SubCategory> SubCategories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("User ID=postgres;Password=patil123;Host=localhost;Port=5432;Database=EF;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasData(
                new Book { BookId = 1, Title = "Spider without Duty", ISBN = "123B12", Price = 10.99m },
                new Book { BookId = 2, Title = "Spider without Duty", ISBN = "123B12", Price = 10.99m }
            );

            var bookList = new Book[]
            {
                new Book { BookId = 3, Title = "Spider without Duty", ISBN = "123B12", Price = 10.99m },
                new Book { BookId = 4, Title = "Spider without Duty", ISBN = "123B12", Price = 10.99m },
                new Book { BookId = 5, Title = "Spider without Duty", ISBN = "123B12", Price = 10.99m },
            };

            modelBuilder.Entity<Book>().HasData(bookList);
        }
    }
}
