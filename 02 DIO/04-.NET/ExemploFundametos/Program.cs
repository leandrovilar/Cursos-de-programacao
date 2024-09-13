using ExemploFundametos.Models;

////Operadores Aritméticos 
//Calculadora / Pontencia
Calculadora calc = new Calculadora();
// calc.Somar(10,20);
// calc.Subtrair(50,10);
// calc.Multiplicar(5,10);
// calc.Dividir(100,5);

calc.Potencia(3,3);



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