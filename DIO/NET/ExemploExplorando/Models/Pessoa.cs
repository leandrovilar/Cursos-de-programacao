using System.Collections.Specialized; // Namespace não utilizado
using System.Reflection; // Namespace não utilizado
using System.Reflection.Metadata; // Namespace não utilizado

namespace ExemploExplorando.Models
{
    public class Pessoa
    {
        // Construtor padrão (sem parâmetros)
        public Pessoa() { }

        // Construtor com implementação (permite inicializar propriedades ao criar uma instância)
        public Pessoa(string nome, string sobrenome, decimal altura)
        {
            Nome = nome; // Inicializa o nome
            Sobrenome = sobrenome; // Inicializa o sobrenome
            Altura = altura; // Inicializa a altura
        }

        // Método de desconstrução (permite desconstruir o objeto em variáveis separadas)
        public void deconstruct(out string nome, out string sobrenome)
        {
            nome = Nome; // Atribui o valor de Nome à variável de saída
            sobrenome = Sobrenome; // Atribui o valor de Sobrenome à variável de saída

            // O código abaixo está comentado pois causaria erro:
            // altura = Altura; 
        }

        // Campo privado para armazenar o valor de Nome
        private string _nome;

        // Campo privado para armazenar o valor de Idade
        private int _idade;

        // Propriedade Nome (com validação no set e transformação no get)
        public string Nome
        {
            // Expressão de corpo (body expression) para retornar o Nome em letras maiúsculas
            get => _nome.ToUpper();

            // Validação ao atribuir valor à propriedade
            set
            {
                if (value == "") // Se o valor for vazio, lança uma exceção
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }
                _nome = value; // Atribui o valor ao campo privado
            }
        }

        // Propriedade automática para Sobrenome
        public string Sobrenome { get; set; }

        // Propriedade somente leitura que retorna o nome completo em letras maiúsculas
        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();

        // Propriedade automática para Altura
        public decimal Altura { get; set; }

        // Propriedade Idade com validação no set
        public int Idade
        {
            // Expressão de corpo para obter o valor de Idade
            get => _idade;

            // Validação para evitar valores inválidos
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("A idade não pode ser menor ou igual a zero");
                }
                _idade = value; // Atribui o valor ao campo privado
            }
        }

        // Método para apresentar as informações da pessoa
        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {NomeCompleto} e eu tenho {Idade} anos.");
        }
    }
}
