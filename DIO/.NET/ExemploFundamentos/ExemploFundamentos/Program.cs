﻿using System.IO.Compression;
using System.Runtime.InteropServices.Marshalling;
using System.Runtime.Serialization;
using ExemploFundamentos.Common.Models;


////Comentários e Boas Práticas em C#-------------------------------------------

//Pessoa p1 = new Pessoa();

/*
Atribui o nome e idade para pessoa
passando o nome Leandro
e passand a idade 44
*/
/*
p1.Nome = "Leandro";
p1.Idade = 44;

//Faz a pessa se apresentar
p1.Apresentar();

Calculadora c = new Calculadora();
c.Somar(5,5); 
*/



////Array-----------------------------------------------------------------------
///Trabalhando com listas
/*
List<string> listaString = new List<string>();
listaString.Add("DF");
listaString.Add("GO");
listaString.Add("PE");
listaString.Add("CE");
listaString.Add("RJ");

Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

listaString.Add("CA");

Console.WriteLine($"Itens na mianha lista: {listaString.Count } - Capacidade: {listaString.Capacity}");

listaString.Remove("GO");

Console.WriteLine($"Itens na mianha lista: {listaString.Count } - Capacidade: {listaString.Capacity}");
*/

///Implementando um array de inteiros
// int [] arrayInteiros = new int[3];
// arrayInteiros[0] = 72;
// arrayInteiros[1] = 64;
// arrayInteiros[2] = 50;

//Copiando um Array para outro
//int [] arrayInteirosDobrado = new int[arrayInteiros.Length * 2];

//Redimensionando um Array
//Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);

//Percorrendo Array com o FOR
// for (int contador = 0; contador < arrayInteiros.Length; contador++)
// {
//     Console.WriteLine($"Posição n° {contador} - {arrayInteiros[contador]}");
// }

//Percorrendo Array com o FOREACH
// int contadorForeach = 0;
// foreach (int valor in arrayInteiros)
// {
//     Console.WriteLine($"Posição n° {contadorForeach} - {valor}");
// }





////Estruturas de repetição-----------------------------------------------------
///Construindo um menu interativo
// string opcao;
// bool exibirMenu = true;
// while(exibirMenu)
// {
//     Console.WriteLine("Ditite a sua opção");
//     Console.WriteLine("1 - Cadastro cliente");
//     Console.WriteLine("2 - Buscar cliente");
//     Console.WriteLine("3 - Apagar Cliente");
//     Console.WriteLine("4 - Encerrar");

//     opcao = Console.ReadLine();
    
//     switch (opcao)
//     {
//         case "1":
//         Console.WriteLine("Cadastro de Cliente");
//         break;

//         case "2":
//         Console.WriteLine("Busca de cliete");
//         break;

//         case "3":
//         Console.WriteLine("Apagar cliente");
//         break;

//         case "4":
//         Console.WriteLine("Encerrar");
//         exibirMenu = false;
//         //Environment.Exit(0);
//         break;

//         default:
//         Console.WriteLine("Opção inválida");
//         break;
//     }
// }


///Introdução ao DO WHILE
// int soma = 0, numero = 0;
// do
// {
//     Console.WriteLine("Digite um número (0 para parar)");
//     numero = Convert.ToInt32(Console.ReadLine());
//     soma += numero;

// } while (numero != 0);
// Console.WriteLine($"Total de soma dos números digitados é: {soma}");


///Introdução ao WHILE(enquanto)
// int numero = 5;
// int contador = 0;//1

// while (contador <= 10)
// {
//     Console.WriteLine($"{contador + 1}° Execução {numero} x {contador} = {numero * contador}");
//     contador++;
//     //interrompendo o fluxo de execução
//     if (contador == 5)
//     {
//         break;
//     }
// }


///Introdução ao FOR(repetição)
// int numero = 5;
// for (int contador = 0; contador <= 10; contador++)
// {
//     Console.WriteLine($"{numero} x {contador} = {numero * contador}");
// }


////Operadores Aritméticos------------------------------------------------------ 
///Calculadora / Pontencia
// Calculadora calc = new Calculadora();
//Calculando raiz quadrada
// calc.RaizQuadrada(9);


//Incremento e Decremento
// int numeroIncremento = 10;
// Console.WriteLine(numeroIncremento);
// Console.WriteLine("Incrementando o 10");
//numeroIncremento = numeroIncremento + 1;
// numeroIncremento++;
// Console.WriteLine(numeroIncremento);

// int numeroDecremento = 20;
// Console.WriteLine(numeroDecremento);
// Console.WriteLine("Decrementando o 20");
// numeroDecremento--;
// Console.WriteLine(numeroDecremento);


///Funcoes trigonometricas
// calc.Seno(30);
// calc.Coseno(30);
// calc.Tangente(30);

// calc.Potencia(3,3);

// calc.Somar(10,20);
// calc.Subtrair(50,10);
// calc.Multiplicar(5,10);
// calc.Dividir(100,5);


////Operador logico
//Operador NOT !

// bool chovel = false;
// bool estaTarde = false;

// if (!chovel && !estaTarde)
// {
//     Console.WriteLine("Vou pedalar");
// }
// else
// {
//     Console.WriteLine("Vou pedalar um outro dia");
// }

//Operador and &&
// bool possuiPresencaMinima = true;
// double media = 5.5;

// if (possuiPresencaMinima && media >= 7)
// {
//     Console.WriteLine("Aprovado!");
// }
// else
// {
//     Console.WriteLine("Reprovado");
// }

//Operador OR ||
// bool ehMaiorDeIdade = true;
// bool possuiAutorizacaoDoResponsavel = false;
// if (ehMaiorDeIdade || possuiAutorizacaoDoResponsavel)
// {
//     Console.WriteLine("Entrada Liberada!");
// }
// else{
//     Console.WriteLine("Entrada nao liberada");
// }


//// Operador condicional

//switch case
// Console.WriteLine("Digite uma letra");
// string letra = Console.ReadLine();

// switch (letra)
// {
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//         Console.WriteLine("Vogal");
//         break;
//     default:
//         Console.WriteLine("não é uma vocal");
//         break;
// }


//if aninhado
// int quantidadeEmEstoque = 10;
// int quantidadeCompra = 4;
// bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

// Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
// Console.WriteLine($"Quantidade de compra: {quantidadeCompra}");
// Console.WriteLine($"É possível realizar a venda: {possivelVenda}");

// if (quantidadeCompra == 0)
// {
//     Console.WriteLine("Venda invalida.");
// }
// else if (possivelVenda)
// {
//     Console.WriteLine("Venda realizada.");
// }
// else
// {
//     Console.WriteLine("Desculpe. Nao temos a quantidade desejada em estoque.");
// }


//Operador condicional na prática
// int quantidadeEmEstoque = 10;
// int quantidadeCompra = 4;
// bool possivelVenda = quantidadeEmEstoque >= quantidadeCompra;

// Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
// Console.WriteLine($"Quantidade de compra: {quantidadeCompra}");
// Console.WriteLine($"É possível realizar a venda: {possivelVenda}");

// if (possivelVenda)
// {
//     Console.WriteLine("Venda realizada.");
// }
// else
// {
//     Console.WriteLine("Desculpe. Nao temos a quantidade desejada em estoque.");
// }

//_____________________________________________
//Ordem dos operadores - (), xº,* ou /, + ou -
// double a = 4 / (2+2);
// Console.WriteLine(a);

//Cast Implicito - conversao de diferentes tipos 
//conversao automatica
// int a = 5;
// double b = a;
//conversao automatica
// int a = 5;
// long b = 5;

//erro long é maior que int
// long b = 5;
// int a = 5;


// Console.WriteLine(b);

//Conversão para string
//int inteiro = 5;
//string a = inteiro.ToString();
//Console.WriteLine(a);

//Diferença entre Convert e Perse
// int a = Convert.ToInt32(null); // resultado 0 (zero)
// int a = int.Parse(null); // resultado unhandled exception (erro)
// Console.WriteLine(a);


//Convertendo tipos de variáveis
// Cast - Casting
// int a = Convert.ToInt32("5");
// int a = int.Parse("5");
// Console.WriteLine(a);

//Combinando Operadores
// int a = 10;
// int b = 20;
// int c = a + b;
// c = c + 5;
// c = c - 5;
// c += 5;
// c *= 5;

//Introdução operador atribuição
// int a = 10;
// int b = 20;
// int c = a + b;
// Console.WriteLine(c);




// DateTime dataAtual = DateTime.Now.AddDays(5);
// Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));

//string apresentacao = "Olá, seja bem vindo"; 

// int quantidade = 1;
// Console.WriteLine("Valor da variável quantidade: "+ quantidade);

// quantidade = 10;
// Console.WriteLine("Valor da variável quantidade: "+ quantidade);

// double altura = 1.80;
// decimal preco = 1.80m;
// bool condicao = true;

// Console.WriteLine(apresentacao);
// Console.WriteLine("Valor da variável quantidade: "+ quantidade);
// Console.WriteLine("Valor da variável altura: " + altura.ToString("0.00"));
// Console.WriteLine("Valor da variável preço: " + preco);
// Console.WriteLine("Valor da variável condicao: " +condicao );


// Pessoa p = new Pessoa
// {
//     Nome = "Leandro",
//     Idade = 44
// };
// p.Apresentar();