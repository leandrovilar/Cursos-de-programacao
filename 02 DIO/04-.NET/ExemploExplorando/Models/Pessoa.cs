using System.Collections.Specialized;

namespace ExemploExplorando.Models
{
    public class Pessoa
    {
        //Construdor
        public Pessoa() {}

        //Construtor com implementação
        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }

        private string _nome;
        private int _idade;
        public string Nome
        {
            //Body Expressions
            // Retorna o nome em letras maiúsculas
            get => _nome.ToUpper();

            // get
            // {
            //// Retorna o nome em letras maiúsculas
            //     return _nome.ToUpper();
            // }

            set
            {
                // Valida se o nome não é vazio
                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }
                _nome = value;
            }
        }
        public string Sobrenome { get; set; }

        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();
        public int Idade
        {
            //Body Expressions
            get => _idade;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Aidade não pode ser menor ou igual a zero");
                }
                _idade = value;
            }
        }

        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {NomeCompleto} e eu tenho {Idade} anos.");
        }
    }
}