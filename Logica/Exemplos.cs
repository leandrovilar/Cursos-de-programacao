using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Contracts;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Logica
{

    //7.Estrutura Condicional (Switch) (Simular um menu)
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha uam opção");
            Console.WriteLine("1 - Mostar Mensagem");
            Console.WriteLine("2 - Exibir data atual");
            Console.WriteLine("3 - Sair");

            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Olá, seja bem-vindo");
                    break;
                case 2:
                    Console.WriteLine($"Data atual: {DateTime.Now}");
                    break;
                case 3:
                    Console.WriteLine("Saindo do program...");
                    break;
                default:
                    Console.WriteLine("Opção invalida");
                    break;
            }
        }
    }






    // //6. Estrutura de Repetição (For) (Exibir os números de 1 a 10)

    // class Program{
    //     static void Main(string[] args){
    //         for (int i = 0; i <= 10; i++){
    //             Console.WriteLine($"Número: {i}");
    //         }
    //     }
    // }


    // //Exemplo: Calcular o fatorial de um número
    // class Program
    // {
    //     static void Main(string[] args)
    //     {
    //         Console.WriteLine("Digite o número para calcuar o fatorial");
    //         int numero = int.Parse(Console.ReadLine());
    //         int fatorial = 1;

    //         for (int i = 1; i <= numero; i++)
    //         {
    //             fatorial *= i;
    //         }
    //         Console.WriteLine($"O fatorial de {numero} é {fatorial}");
    //     }
    // }


    // //5. Estrutura de Repetição (Do-While) (Ler números até o usuário digitar zero)
    // class Program
    // {
    //     static void Main(string[] args)
    //     {
    //         int numero;

    //         do
    //         {
    //             Console.WriteLine("Digite o valor 0 para parar");
    //             numero = int.Parse(Console.ReadLine());
    //             if (numero != 0)
    //             {
    //                 Console.WriteLine($"Voce digiteo o {numero}");
    //             }
    //         } while (numero != 0);

    //         Console.WriteLine("Fim do programa");
    //     }
    // }



    // //4. Estrutura de Repetição (While) (Exemplo: Contar até 5)
    // class Program
    // {
    //     static void Main(string[] args)
    //     {
    //         int contador = 1;

    //         while (contador <= 5)
    //         {
    //             Console.WriteLine($"Contador: {contador}");
    //             contador++;
    //         }
    //     }
    // }


    // // Ler números até o usuário digitar zero
    // class Program
    // {
    //     static void Main(string[] args)
    //     {
    //         Console.WriteLine("Digite número. Digite 0 para encerrar.");
    //         int numero = int.Parse(Console.ReadLine());

    //         while (numero != 0)
    //         {
    //             Console.WriteLine($"Você digitou: {numero}");
    //             numero = int.Parse(Console.ReadLine());
    //         }
    //         Console.WriteLine("Fim do programa.");
    //     }
    // }


    // //3. Estrutura Condicional com Múltiplas Condições (Classificar uma nota)
    //     class Program
    //     {
    //         static void Main(string[] args)
    //         {
    //             Console.Write("Digite uma nota de 0 a 100:  ");
    //             int nota = int.Parse(Console.ReadLine());

    //             if (nota >= 90)
    //             {
    //                 Console.WriteLine("Aprovado com Excelente!.");
    //             }
    //             else if (nota >= 70)
    //             {
    //                 Console.WriteLine("Aprovado.");
    //             }
    //             else
    //             {
    //                 Console.WriteLine("Reprovaodo.");
    //             }
    //         }
    //     }



    //2. Estrutura Condicional Composta (Verificar se um número é positivo ou negativo)
    // class Program
    // {
    //     static void Main (string[] args)
    //     {
    //         Console.WriteLine("Digite um número");
    //         int numero = int.Parse(Console.ReadLine());

    //         if(numero > 0)
    //         {
    //             Console.WriteLine($"Número: {numero} é positivo.");
    //         }
    //         else
    //         {
    //             Console.WriteLine($"Número: {numero} é negativo ou 0.");
    //         }
    //     }
    // }


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