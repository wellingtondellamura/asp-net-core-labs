using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace entity_demo.model
{
    public class Categoria
    {

        public Int32 CategoriaId {get;set;}
        
        [MaxLength(20)]
        public string Descricao {get;set;}


        public List<Tarefa> Tarefas { get; set; }
    }
}