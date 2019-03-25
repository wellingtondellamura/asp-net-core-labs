using System;

namespace entity_demo.model
{
    
    public class Tarefa
    {
        public Int32 TarefaId {get;set;}
        public string Descricao {get;set;}
        public Int32 Prioridade {get;set;}

        public int CategoriaId { get; set; }
        public Categoria Categoria {get;set;}
    }
}