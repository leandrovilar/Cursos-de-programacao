namespace ExemploExplorando.Models
{
    public class Pessoa
    {
        private string _nome;
        public string Nome
        {
            get
            {
                 // Retorna o nome em letras maiúsculas
                return _nome.ToUpper();
            }

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
        public int Idade { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e eu tenho {Idade} anos.");
        }
    }
}