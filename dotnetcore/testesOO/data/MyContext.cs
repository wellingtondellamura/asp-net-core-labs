using Microsoft.EntityFrameworkCore;
using testesOO.model;

namespace testesOO.data
{
    public class MyContext : DbContext
    {
        public DbSet<Curso> Cursos {get;set;}
        public DbSet<Aluno> Alunos {get;set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(@"Server=localhost;database=uenp3;uid=root;pwd=abc123*;");
        }
    }
}