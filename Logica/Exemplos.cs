using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Logica
{

    //2. Estrutura Condicional Composta (Verificar se um número é positivo ou negativo)
    class Program
    {
        static void Main (string[] args)
        {
            Console.WriteLine("Digite um número");
            int numero = int.Parse(Console.ReadLine());

            if(numero > 0)
            {
                Console.WriteLine($"Número: {numero} é positivo.");
            }
            else
            {
                Console.WriteLine($"Número: {numero} é negativo ou 0.");
            }
        }
    }


    // //1. Estrutura Condicional Simples - (Verificar se um número é positivo)
    // public class Exemplos
    // {
    //     class Program
    //     {
    //         static void Main(string[] args)
    //         {
    //             Console.WriteLine("Digite um numero:");
    //             int numero = int.Parse(Console.ReadLine());

    //             if (numero > 0)
    //             {
    //                 Console.WriteLine($"Número {numero} é positivo.");
    //             }
    //         }
    //     }
    // }



    // -------Simular um menu
    // Algoritmo:
    // Apresentar opções (1 para somar, 2 para subtrair).
    // Ler a escolha e executar a operação correspondente.
    // class Program
    // {
    //     static void Main(string[] args)
    //     {
    //         Console.WriteLine("Escolha uma operação:");
    //         Console.WriteLine("1 - Soma");
    //         Console.WriteLine("2 - Subtração");

    //         int opcao = int.Parse(Console.ReadLine());

    //         Console.WriteLine("Digite dois números:");
    //         int num1 = int.Parse(Console.ReadLine());
    //           int num2 = int.Parse(Console.ReadLine());

    //         switch (opcao)
    //         {
    //             case 1:
    //                 Console.WriteLine($"Resultado da soma:  {num1 + num2}");
    //                 break;
    //             case 2:
    //                 Console.WriteLine($"Resultado da subtração: {num1 - num2}");
    //                 break;
    //             default:
    //                 Console.WriteLine("Opção inválida.");
    //                 break;
    //         }
    //     }
    // }

    //------Exibir a tabuada de um número
    // Algoritmo:
    // Ler um número.
    // Usar um for para multiplicar de 1 a 10 e exibir os resultados.
    // class Program{
    //     static void Main(string[] args){
    //         Console.WriteLine("Digite um número para ver a tabuada:");
    //         int numero = int.Parse(Console.ReadLine());

    //         for (int i = 1; i <= 10; i++){
    //             Console.WriteLine($"{numero} x {i} = {numero * i}");
    //         }

    //     }
    // }

    //-------Verificar se um número é par ou impar
    // Algoritmo:
    // Ler um número.
    // Verificar se o resto da divisão por 2 é 0.
    // Exibir se é par ou ímpar.

    // class Program{
    //     static void Main (string[] args){
    //         Console.Write("Digite um número");
    //         int numero = int.Parse(Console.ReadLine());

    //         if (numero % 2 == 0){
    //             Console.WriteLine("O número é par: ");
    //         }else{
    //             Console.WriteLine("O número e ímpar: ");
    //         }
    //     }
    // }

}