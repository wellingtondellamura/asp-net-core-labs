using BookStore.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Data
{
    public class BookStoreDBContext: DbContext
    {
        public BookStoreDBContext(DbContextOptions<BookStoreDBContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Book> Books { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().ToTable("Category");            
            modelBuilder.Entity<Book>().ToTable("Book");
        }
    }
}