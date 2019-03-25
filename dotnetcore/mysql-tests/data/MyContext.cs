
using Microsoft.EntityFrameworkCore;

namespace mysql_tests.data
{
public class MyContext : DbContext
    {
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Carro> Carros { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder
                .UseMySql(@"Server=localhost;database=brunodemo;uid=root;pwd=abc123*;");
    }
}