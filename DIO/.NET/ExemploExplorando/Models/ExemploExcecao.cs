using System; // Namespace para manipulação de exceções e entrada/saída
using System.Collections; // Namespace não utilizado
using System.Collections.Generic; // Namespace não utilizado
using System.Linq; // Namespace não utilizado
using System.Threading.Tasks; // Namespace não utilizado

// Exemplo de propagação e tratamento de exceções
namespace ExemploExplorando
{
    public class ExemploExcecao
    {
        // Método que inicia a cadeia de chamadas e trata as exceções propagadas
        public void Metodo1()
        {
            try
            {
                // Chama o próximo método na cadeia
                Metodo2();
            }
            catch (Exception ex)
            {
                // Trata a exceção lançada e exibe a mensagem de erro com a pilha de chamadas
                Console.WriteLine("Exceção tratada. " + ex.StackTrace);
            }
        }

        // Método que simplesmente chama o próximo na cadeia
        public void Metodo2()
        {
            Metodo3(); // Encaminha para o próximo método
        }

        // Método que chama o próximo método na cadeia
        public void Metodo3()
        {
            Metodo4(); // Encaminha para o próximo método
        }

        // Método que lança explicitamente uma exceção
        public void Metodo4()
        {
            // Lança uma nova exceção que será propagada pela cadeia de métodos
            throw new Exception("Ocorreu uma exceção");
        }
    }
}
