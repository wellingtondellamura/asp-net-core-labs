using System;
using System.Linq;
using entity_demo.data;
using entity_demo.model;
using Microsoft.EntityFrameworkCore;

namespace entity_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            TarefasContext ctx = new TarefasContext();
        // ctx.Add(new Categoria(){Descricao="Pessoal"});
        // ctx.SaveChanges();

            //  var c = ctx.Categorias.Find(1);
            //  Console.WriteLine(c);

// var c = ctx.Categorias.Find(1);

// for (int i = 0; i< 10; i++){
//    var t = new Tarefa();
//    t.Prioridade = 1;
//    t.Descricao = String.Format("Teste {0}", i);
//    t.Categoria = c;
//    ctx.Tarefas.Add(t);
// }

//  ctx.SaveChanges();

            // var tarefas = ctx.Tarefas
            //         .Include(tarefa => tarefa.Categoria);
                
            var c = ctx.Categorias.Find(1);
                
        var tarefas  = c.Tarefas;
        c.Tarefas.ForEach(tt => {
            Console.WriteLine(String.Format("{0} \t {1} \t {2}", tt.TarefaId, tt.Descricao, tt.Categoria.Descricao));
        });            
            
        }
    }
}
