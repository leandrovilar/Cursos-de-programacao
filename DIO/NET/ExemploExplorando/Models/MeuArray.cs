using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    // Declara a classe genérica MeuArray, que pode armazenar elementos de qualquer tipo T
    public class MeuArray<T>
    {
        // Define a capacidade máxima do array como 10
        private static int capacidade = 10;
        
        // Contador para rastrear o número de elementos adicionados
        private int contador = 0;
        
        // Cria um array de elementos do tipo T com a capacidade definida
        private T[] array = new T[capacidade];

        // Método para adicionar um elemento ao array
        public void AdicionarElementoArray(T elemento)
        {
            // Verifica se ainda há espaço no array para adicionar um elemento
            if (contador + 1 < 11)
            {
                // Adiciona o elemento na posição indicada por contador
                array[contador] = elemento;
            }
            // Incrementa o contador independentemente da condição
            contador++;
        }

        // Indexador que permite acessar ou definir um elemento pelo índice
        public T this[int index]
        {
            // Retorna o elemento no índice especificado
            get { return array[index]; }
            // Define o valor de um elemento no índice especificado
            set { array[index] = value; }
        }
    }
}
/*
Observações adicionais:
O if dentro de AdicionarElementoArray verifica o limite de capacidade, mas o incremento de contador fora do if faz com que ele possa ultrapassar o limite do array, causando uma exceção IndexOutOfRangeException após 10 inserções.
*/