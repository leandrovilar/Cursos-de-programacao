using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    // Define uma classe estática para armazenar métodos de extensão
    public static class IntExtensions
    {
        // Método de extensão que verifica se um número inteiro é par
        // 'this int numero' permite que o método seja usado como uma extensão em instâncias de int
        public static bool EhPar(this int numero)
        {
            // Retorna true se o número for par (divisível por 2 sem resto), caso contrário, retorna false
            return numero % 2 == 0;
        }
    }
}
/*
Explicação adicional:
Este código cria um método de extensão EhPar para a estrutura int. Com ele, é possível verificar diretamente se um número é par chamando numero.EhPar(). O uso de this antes do parâmetro int numero indica que o método é uma extensão de int.
*/