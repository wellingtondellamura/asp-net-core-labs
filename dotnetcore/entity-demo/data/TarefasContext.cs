using entity_demo.model;
using Microsoft.EntityFrameworkCore;

namespace entity_demo.data
{
    public class TarefasContext: DbContext
    {
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Tarefa> Tarefas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(@"Server=localhost;database=tarefas2;uid=root;pwd=abc123*;");
        }
    }
}