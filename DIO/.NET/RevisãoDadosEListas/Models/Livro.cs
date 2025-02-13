using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RevisãoDadosEListas.Models
{
    public class Livro
    {
// Campo privado para armazenar       
        private string _titulo;
        private string _autor;
        private int _anoPublicacao;
        public bool Disponivel { get; private set; } = true;

 // Propriedade Título: valida se o título não é nulo ou vazio.
        public string Titulo
        {
            get => _titulo;
 // Define o valor do título, validando que não pode ser vazio ou nulo
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                throw new ArgumentException("O título não pode ser vazio");
                }
                _titulo = value;
            }
        }
        public string Autor 
        { 
            // Obtém o valor do autor
            get => _autor; 
            // Define o valor do autor, validando que não pode ser vazio ou nulo
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("O autor nao pode ser vazio");
                }
                _autor = value;

            }
        }


    }
}