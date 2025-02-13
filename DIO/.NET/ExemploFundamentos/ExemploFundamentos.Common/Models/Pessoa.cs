using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Common.Models
{
  
   // Representa uma pessoa física
     public class Pessoa
    {
       // Caracteristica da pessoa(dados)
        public required string Nome { get; set; }
        public int Idade { get; set; }

         // Faz a pessoa se apresentar(Metodos (função))
            public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, e tenho {Idade} anos");
        }
    }
}