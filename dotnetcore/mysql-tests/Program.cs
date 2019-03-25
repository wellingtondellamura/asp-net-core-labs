using System;
using System.Linq;
using mysql_tests.data;

namespace mysql_tests
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new MyContext())
            {
                context.Database.EnsureCreated();
                Pessoa pessoa = new Pessoa(){Nome="Maria de Oliveira", Email="maria@hotmail.com"};
                context.Pessoas.Add(pessoa);
                Carro carro = new Carro(){Placa="ABC1234", Dono=pessoa};
                context.Carros.Add(carro);
                context.SaveChanges();
            }
            Console.WriteLine("Hello World!");
        }
    }
}
