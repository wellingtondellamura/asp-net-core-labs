using System;

namespace mysql_tests.data
{
    public class Carro
    {
        public Int32 Id {get;set;}
        public string Placa{get;set;}
        public Pessoa Dono{get;set;}
    }
}