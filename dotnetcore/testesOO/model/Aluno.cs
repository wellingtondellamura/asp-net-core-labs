using System;

namespace testesOO.model
{
    public class Aluno
    {     
        public Int32 AlunoId{get;set;}
        public string Nome {get; set;}
        public string Email {get; set;}
        public string Telefone {get; set;}

        public Int32 CursoId{get;set;}
        public Curso Curso{get;set;}

        public Aluno(string nome, string email, string telefone)
        {
            Nome = nome;
            Email = email;
            Telefone = telefone;

        }

        public Aluno(string nome, string email) : this(nome, email, null){}

        public string DigaOla(string saudacao = "Olá")
        {
            return $"{saudacao} {Nome}";
        }

    }

}