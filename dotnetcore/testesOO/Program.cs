using System;
using System.Linq;
using testesOO.data;
using testesOO.model;
using Microsoft.EntityFrameworkCore;

namespace testesOO
{
    class Program
    {
        static void Main(string[] args)
        {
           var ctx = new MyContext();
           //ctx.Database.EnsureCreated();
        //    foreach (var c in ctx.Cursos)
        //    {
        //        Console.WriteLine(String.Format("{0} \t {1}", c.CursoId, c.Nome));
        //    }
        //    var c = ctx.Cursos.Find(2);
        //    Console.WriteLine(String.Format("{0} \t {1}", c.CursoId, c.Nome));

            ctx.Cursos
                .Where(c => c.Duracao <= 4)
                .ToList().ForEach(cc => {
                    Console.WriteLine(String.Format("{0} \t {1}", cc.CursoId, cc.Nome));
                });

            
            var alunos = ctx.Alunos.Include(a => a.Curso);
            foreach (var item in alunos)
            {
                item.Curso.Duracao;
            }

           ctx.SaveChanges();
        }
    }
}
