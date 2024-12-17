using System; // Namespace para tipos básicos e manipulação de datas
using System.Collections.Generic; // Namespace não utilizado
using System.Linq; // Namespace não utilizado
using System.Threading.Tasks; // Namespace não utilizado
using Newtonsoft.Json; // Biblioteca para serialização/deserialização JSON

namespace ExemploExplorando.Models
{
    public class Venda
    {
        // Construtor para inicializar os atributos obrigatórios da classe
        public Venda(int id, string produto, decimal preco, DateTime dataVenda)
        {
            Id = id; // Inicializa o ID da venda
            Produto = produto; // Inicializa o nome do produto
            Preco = preco; // Inicializa o preço do produto
            DataVenda = dataVenda; // Inicializa a data da venda
        }

        // Propriedade que representa o ID da venda
        public int Id { get; set; }

        // Propriedade para o nome do produto
        // O atributo [JsonProperty] altera o nome do campo durante a serialização/deserialização JSON
        [JsonProperty("Nome_Produto")]
        public string Produto { get; set; }

        // Propriedade para o preço do produto
        public decimal Preco { get; set; }

        // Propriedade para a data em que a venda foi realizada
        public DateTime DataVenda { get; set; }

        // Propriedade opcional para desconto (aceita valores nulos)
        public decimal? Desconto { get; set; }
    }
}
