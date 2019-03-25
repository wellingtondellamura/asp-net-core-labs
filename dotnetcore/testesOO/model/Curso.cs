using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace testesOO.model
{
    public class Curso
    {
        public Int32 CursoId{get;set;}
        
        [MaxLength(50)]
        public string Nome{get;set;}
        public Int32 Duracao{get;set;}

        public List<Aluno> Alunos{get;set;}
    }
}