using simple_crud.Models;
using Microsoft.EntityFrameworkCore;

namespace simple_crud.Data
{
    public class MoviesDBContext: DbContext
    {
        public MoviesDBContext(DbContextOptions<MoviesDBContext> options) : base(options)
        {
        }

        public DbSet<Genre> Genres { get; set; }
        public DbSet<Movie> Movies { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Genre>().ToTable("Genre");
            modelBuilder.Entity<Movie>().ToTable("Movie");
        }
    }
}

