using System;
using System.Diagnostics;

//Função com retorno


class Program
{
    // Função que recebe dois números e retorna a soma
    public static int Somar(int a, int b)
    {
        return a + b; // Retorna a soma de dois números
    }

    // Método principal do programa
    static void Main()
    {
        int resultado = Somar(5, 3); // Chamando a função e armazenando o retorno
        Console.WriteLine($"A soma é: {resultado}"); // Exibindo o resultado
    }
}


// //Funções com Parãmetros (valores)
// class Program
// {
//     // Função(método) que recebe um parâmetro e exibe uma mensagem
//     public static void ExibirMensagem(string nome)
//     {
//         Console.WriteLine($"Olá, {nome}! Bem-vindo ao C#.");
//     }
//Função(método) principal do programa
//     static void Main()
//     {
//         ExibirMensagem("Leandro"); // Chamando a função com argumento
//     }
// }


// //Chamando a função:
// class Program
// {
//     static void Main()
//     {
//         MinhaFuncao(); //Chamando a função
//     }
//     public static void MinhaFuncao() //Função
//     {
//         Console.WriteLine("Olá, mundo das funções!");
//     }
// }


// //Estrutura básica da função
// public static void MinhaFuncao()
// {
//     Console.WriteLine("Olá, munto das funções");
// }

// Explicação:
// public static → Define o escopo e permite chamar a função sem precisar instanciar uma classe.
// void → Indica que a função não retorna nenhum valor.
// MinhaFuncao() → Nome da função.
// {} → Bloco de código que será executado quando a função for chamada.


//Estrutura de Controle Condicional (Switch)
// class Program
// {
//     static void Main(string[] args)
//     {
//         int opcao = 3;

//         switch (opcao)
//         {
//             case 1:
//                 Console.WriteLine("Você escolheu a opção 1");
//                 break;
//             case 2:
//                 Console.WriteLine("Você escolheu a opção 2");
//                 break;
//             default:
//                 Console.WriteLine("Opção Invalido");
//                 break;
//         }
//     }
// }





// //For (Executar um número fixo de vezes.)
// class Program{
//     static void Main(string[] args){
//         for (int i = 1; i <= 50; i++){
//             Console.WriteLine($"Contador: {i}");
//         }
//     }
// }





// //Do-While (Repetição com Teste no Final)
// class Program{
//     static void Main(string[] args){
//         int contador = 1;

//         do
//         {
//             Console.WriteLine($"Contador: {contador}");
//             contador++;
//         } while (contador <= 100);
//     }
// }





// //While (Repetição com Teste no Início)
// using System;
// class Program{
//     static void Main(string[] args){
//         int contador = 1;

//         while(contador <= 5){
//             Console.WriteLine($"contador: {contador}");
//             contador++;
//         }
//     }
// }




// // Estrutura de multiplas condições
// int nota = 50;

// if (nota >= 90)
// {
//     Console.WriteLine("Otima nota");
// }
// else if (nota >= 70)
// {
//     Console.WriteLine("Boa nota");
// }
// else
// {
//     Console.WriteLine("Reprovado");
// }





// //Estrutura composta if, else
// int idade = 10;

// if ( idade >= 18)
// {
//     Console.WriteLine("É mair de idade");
// }
// else
// {
//     Console.WriteLine("É menor de idade");
// }





// //Estrutura simples if
// int idade = 20;

// if (idade >= 18)
// {
//     Console.WriteLine("É mair de idade.");
// }





//-----> Operação

// using System;
// class Program{
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Digite três números: ");
//         int num1 = int.Parse(Console.ReadLine());
//         int num2 = int.Parse(Console.ReadLine());
//         int num3 = int.Parse(Console.ReadLine());

//         double media = (num1 + num2 + num3) / 3.0;

//         Console.WriteLine($"A média é: {media}");
//     }
// }





//-----> Matriz
// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         //Declarar e inicialiar matriz
//         int[,] matriz = {
//             {10, 20, 30},
//             {40, 50, 60},
//             {70, 80, 90}
//         };

//         for (int i = 0; i < matriz.GetLength(0); i++)//Loop para linhas
//         {
//             for (int j = 0; j < matriz.GetLength(1); j++)//loop para colunas
//             {
//                 Console.WriteLine($"Elemento [{i}][{j}]: {matriz[i, j]}");
//             }
//         }
//     }
// }




//-----> Vetor
// using System;
// using System.Configuration.Assemblies;
// using System.Numerics;
// using System.Runtime.ExceptionServices;
// class Program
// {
//     static void Main(string[] args)
//     {
//         //Declarar e inicializar vetor
//         int[] vetor = new int[5] { 10, 20, 30, 40, 50 };

//         //Exibir os elementos do vetor
//         for (int i = 0; i < vetor.Length; i++)
//         {
//             Console.WriteLine($"Posição {i}: {vetor[i]}");
//         }
//     }
// }



//-----> Váriaveis
// int idade;           // Variável para armazenar idade
// string nome;         // Variável para armazenar nome
// bool maiorDeIdade;   // Variável para indicar se é maior de idade


//-----> Estrutura geral de um programa
// using System;
// //Início
// class Program{
//     static void Main(String[] args){

//         //Declaraçao de variaveis
//         int n1, n2, soma;

//         //Entrada de dados
//         Console.WriteLine("Digite o primeiro número:");
//         n1 = int.Parse(Console.ReadLine());

//         Console.WriteLine("Digite o segundo número:");
//         n2 = int.Parse(Console.ReadLine());

//         //Processamento de dados
//         soma = n1 + n2;

//         //Saida de dados
//         Console.WriteLine("O número é: " + soma);
//     }
// }
// // Fim


//-----> Algoritimo básico para verificar se um número é par ou ímpar
// int numero = 18;

// if (numero % 2 == 0)
// {
//     Console.WriteLine("O número e par");
// }
// else
// {
//     Console.WriteLine("O número é impar");
// }