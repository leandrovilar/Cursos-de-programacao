using System; // Namespace para tipos básicos e manipulação de exceções
using System.Collections.Generic; // Namespace não utilizado
using System.Data.SqlTypes; // Namespace não utilizado
using System.Linq; // Necessário para o método Count()
using System.Reflection.Metadata.Ecma335; // Namespace não utilizado
using System.Threading.Tasks; // Namespace não utilizado

namespace ExemploExplorando.Models
{
    public class LeituraArquivo
    {
        // Método para ler um arquivo de texto e retornar um tupla com o status e informações do arquivo
        public (bool sucesso, string[] Linhas, int QuantidadeLinhas) LerArquivo(string caminho)
        {
            try
            {
                // Lê todas as linhas do arquivo especificado pelo caminho
                string[] linhas = File.ReadAllLines(caminho);

                // Retorna sucesso (true), as linhas do arquivo e a quantidade de linhas
                return (true, linhas, linhas.Count());
            }
            catch (Exception)
            {
                // Caso ocorra um erro, retorna falha (false), um array vazio e quantidade 0
                return (false, new string[0], 0);
            }
        }
    }
}
