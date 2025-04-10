using ExemploExplorando;
using ExemploExplorando.Models;
using Models;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.Reflection; //Alterando a localização do código




// dynamic variavelDinamica = 4;
// Console.WriteLine($"Tipo da variável: {variavelDinamica.GetType()}, Valor: {variavelDinamica}");

// dynamic variavelDinamica = "Texto";
// Console.WriteLine($"Tipo da variável: {VariavelDinamica.GetType()}, Valor: {variavelDinamica}");

// dynamic variavelDinamica = true;
// Console.WriteLine($"Tipo da variável: {VariavelDinamica.GetType()}, Valor: {variavelDinamica}");





// //Métodos de extensão
// int numero = 15;
// bool par = false;

// //If Ternário
// par = numero.EhPar();

// string mensgem = "O número " + numero + " " + "é " + (par ? "par" : "ímpar");
// Console.WriteLine(mensgem);












// //Testando classe genérica
// //tipo inteiro
// MeuArray<int> arrayInteiro = new MeuArray<int>();
// arrayInteiro.AdicionarElementoArray(30);
// Console.WriteLine(arrayInteiro[0]);

// //tipo string
// MeuArray<string> arrayString = new MeuArray<string>();
// arrayString.AdicionarElementoArray("teste");
// Console.WriteLine(arrayString[0]);
























// //Tipo variavel dinâmica
// // Declara uma variável dinâmica chamada 'variavelDinamica' e atribui a ela um valor inteiro (4)
// // 'dynamic' permite que o tipo da variável seja resolvido em tempo de execução, não em tempo de compilação
// dynamic variavelDinamica = 4;

// // Exibe o tipo atual e o valor da variável no console
// // Neste caso, GetType() retornará 'System.Int32' pois o valor atual é um inteiro
// Console.WriteLine($"Tipo da variável: {variavelDinamica.GetType()}, Valor: {variavelDinamica}");

// // Atribui uma string ("Texto") à mesma variável dinâmica
// // Como 'variavelDinamica' é do tipo 'dynamic', ela pode mudar de tipo em tempo de execução
// variavelDinamica = "Texto";

// // Exibe o novo tipo e o valor da variável no console
// // Agora, GetType() retornará 'System.String' porque o valor atual é uma string
// Console.WriteLine($"Tipo da variável: {variavelDinamica.GetType()}, Valor: {variavelDinamica}");

// // Atribui um valor booleano (true) à variável dinâmica
// // Mais uma vez, o tipo da variável muda em tempo de execução para se adaptar ao novo valor
// variavelDinamica = true;

// // Exibe o tipo e o valor atual da variável no console
// // GetType() retornará 'System.Boolean' já que agora a variável contém um valor booleano
// Console.WriteLine($"Tipo da variável: {variavelDinamica.GetType()}, Valor: {variavelDinamica}");







// //Tipos anonimos em colecao
// // Carrega o conteúdo do arquivo JSON em uma string
// string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

// // Deserializa o conteúdo JSON em uma lista de objetos do tipo Venda
// // Isso converte o JSON em uma lista de instâncias da classe Venda
// List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

// // Cria uma nova lista com objetos anônimos usando LINQ
// // Aqui, estamos selecionando apenas as propriedades "Produto" e "Preco" da lista de vendas
// // O tipo anônimo { Produto, Preco } é útil quando precisamos de apenas algumas propriedades dos objetos da lista
// var ListaAnonimo = listaVenda.Select(x => new { x.Produto, x.Preco });

// // Percorre a lista de objetos anônimos e exibe os dados no console
// foreach (var venda in ListaAnonimo)
// {
//     // Imprime o nome do produto e o preço formatado
//     Console.WriteLine($"Produto: {venda.Produto}, Preço: {venda.Preco} ");
// }













// //Tipo anônimo 
// var tipoAnonimo = new { Nome = "Leandro", Sobrenome = "Braga", Altura = 1.80};

// Console.WriteLine("Nome: " + tipoAnonimo.Nome);
// Console.WriteLine("Sobrenome: " + tipoAnonimo.Sobrenome);
// Console.WriteLine("Altura: " + tipoAnonimo.Altura);












// //Tipos nulos com propriedade
// String conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

// List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

// foreach (Venda venda in listaVenda)
// {
//     Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}, " +
//     $" Preço: {venda.Preco}, Data: {venda.DataVenda.ToString("dd/MM/yyyy HH:mm")}," + 
//     $"{(venda.Desconto.HasValue ? $"Desconto de: {venda.Desconto}" : "")}" );
// }












// //Tipos nulos
// bool? desejaReceberEmail = null;

// if (desejaReceberEmail.HasValue && desejaReceberEmail.Value)
// {
//     Console.WriteLine("O usuário optou por receber e-mail.");
// }
// else
// {
//     Console.WriteLine("O usuário não respondeu ou optou por não receber e-mail");
// }


















// //DESERIALIZANDO UM OBJETO
// String conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

// List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

// foreach (Venda venda in listaVenda)
// {
//     Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}, Preço: {venda.Preco}, Data: {venda.DataVenda.ToString("dd/MM/yyyy HH:mm")}");
// }



















// //SERIALIZANDO OBJETO
// //Data de venda
// DateTime dataAtual = DateTime.Now;

// //Lista de vendas
// List<Venda> listaVenda = new List<Venda>();

// //Instanciar de vendas
// Venda v1 = new Venda(1, "Material de escritório", 25.00M, dataAtual);
// Venda v2 = new Venda(2, "Material de cozinha", 125.00M, dataAtual);

// listaVenda.Add(v1);
// listaVenda.Add(v2);

// //Serealizando com o Json
// string serializando = JsonConvert.SerializeObject(listaVenda, Formatting.Indented);

// //Criando arquivo serializado
// File.WriteAllText("Arquivos/vendas.json", serializando);

// Console.WriteLine(serializando);





















// int numero = 10;
// bool ehPar = false;

// //Formato IF Ternário
// ehPar = numero % 2 == 0;
// Console.WriteLine($"O número {numero} é " + (ehPar ? "par" : "impar"));

// //Formato padrão
// if (numero % 2 == 0)
// {
//     Console.WriteLine($"O número {numero} é par");
//     }
// else
// {
//     Console.WriteLine($"O número {numero} é impar");
// }








// Pessoa p1 = new Pessoa("Leandro", "Vilar");
// (string nome, string sobrenome) = p1;
// Console.WriteLine($"{nome} {sobrenome}");














// LeituraArquivo arquivo = new LeituraArquivo();

// //_ (andeline) serve para retirar uma informacao que nao for usar
// var (sucesso, linhasArquivo, _) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");

// if (sucesso)
// {
//     //Console.WriteLine("Quantidade linhas do arquivo:" + quantidadeLinhas);
//     foreach (string linha in linhasArquivo)
//     {
//         Console.WriteLine(linha);
//     }
// }
// else
// {
//     Console.WriteLine("Não foi possível ler o arquivo");
// }


























// //Tublas 01 - padrão
// (int Id, string Nome, string Sobrenome, decimal Altura) tupla = (1, "Leandro", "Braga", 1.83m);
// // //Tublas 02 
// // ValueTuple<int, string, string, decimal> tupla2 = (1, "Leandro", "Vilar", 1.83m);
// // //Tublas 03
// // var tubla3 = Tuple.Create(1, "Leandro", "Vilar", 1.83m);

// Console.WriteLine($"Id: {tupla.Id}");
// Console.WriteLine($"Nome: {tupla.Nome}");
// Console.WriteLine($"Sobrenome: {tupla.Sobrenome}");
// Console.WriteLine($"Altura: {tupla.Altura}");





// //Tublas
// (int, string, string, decimal) tupla = (1, "Leandro", "Vilar", 1.83m);

// Console.WriteLine($"Id: {tupla.Item1}");
// Console.WriteLine($"Nome: {tupla.Item2}");
// Console.WriteLine($"Sobrenome: {tupla.Item3}");
// Console.WriteLine($"Altura: {tupla.Item4}");













// //Dictionary
// Dictionary<string, string> estados = new Dictionary<string, string>();
// //adicionar valor
// estados.Add("SP", "SÃO PAULO");
// estados.Add("DF", "DISTRITO FEDERAL");
// estados.Add("BA", "BAHIA");

// // //Acessar valor
// // Console.WriteLine(estados["DF"]);

// foreach(var item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }

// // //Remover valor
// // estados.Remove("BA");

// // //Mudar valor
// // estados["SP"] = "São Paulo - é uma Estado rico";

// // foreach(var item in estados)
// // {
// //     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// // }

// //verificando valor
// string chave = "BA";
// Console.WriteLine($"verificando o elemento: {chave}");

// if (estados.ContainsKey(chave))
// {
//     Console.WriteLine($"Valor existente: {chave}");
// }
// else
// {
//     Console.WriteLine($"Valor não existe: {chave}");
// }






















// //Pilha 
// Stack<int> pilha = new Stack<int>();

// pilha.Push(4);
// pilha.Push(6);
// pilha.Push(8);
// pilha.Push(10);

// foreach(int item in pilha)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento do topo: {pilha.Pop()}");

// pilha.Push(20);

// foreach(int item in pilha)
// {
//     Console.WriteLine(item);
// }
















// // Filas 
// Queue<int> fila = new Queue<int>();

// fila.Enqueue(2);
// fila.Enqueue(4);
// fila.Enqueue(6);
// fila.Enqueue(8);
// fila.Enqueue(10);

// foreach(int item in fila)
// {
//     Console.WriteLine(item);
// }
// //fila.Dequeue();
// //Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");

// fila.Enqueue(5);

// foreach(int item in fila)
// {
//     Console.WriteLine(item);
// }









//new ExemploExcecao().Metodo1();

// //tratamento de exceção
// try
// {
//     string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

//     foreach (string linha in linhas)
//     {
//         Console.WriteLine(linha);
//     }
// }
// catch (FileNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado. {ex.Message}");
// }
// catch (DirectoryNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Caminho da pasta não encontrado."  + ex.Message);
// }
// catch (Exception ex)
// {
//     Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
// }
// //Bloco finally (sempre aparece no final de um execução de código)
// finally
// {
//     Console.WriteLine("Chegou até aqui");
// }












// //TryParseExact
// string dataString = "2024-10-16 21:29";

// bool sucesso = DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data);

// if (sucesso)
// {
//     Console.WriteLine($"Conversao com sucesso! Data: {data}");
// }
// else
// {
//     Console.WriteLine($"{dataString} não é uma data válida");
// }







// DateTime data = DateTime.Now;
// //Só data
// Console.WriteLine(data.ToShortDateString());
// //Só hora
// Console.WriteLine(data.ToShortTimeString());


// DateTime data = DateTime.Parse("30/10/2022 21:00");
// Console.WriteLine(data);








// //Formatando o tipo DateTime
// DateTime data = DateTime.Now;
// Console.WriteLine(data.ToString("dd-MM-dd HH:mm"));




















////Alterando a localização do código
//CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-us") //Modo 01

////Concatenação de valores
//decimal valorMonetario = 1980.00m;
//double porcentagem = .3421;

////Formatação personalizada
//Console.WriteLine(porcentagem.ToString("p"));

////Formatação personalizada N ou C
//Console.WriteLine(valorMonetario.ToString("N2"));

//Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));//Modo 02

//Console.WriteLine($"{valorMonetario:C}");//Modo 01







// //Concatenação de valores
// int numero1 = 10;
// int numero2 = 20;

// int resultado = numero1 + numero2;
// Console.WriteLine(resultado);











// // Instanciando a classe Pessoa usando um Construdor
// Pessoa p1 = new Pessoa(nome: "Leandro", sobrenome: "Vilar");

// // Instanciando a classe Pessoa
// Pessoa p2 = new Pessoa();
// // Atribuindo valores às propriedades
// p2.Nome = "Renata";
// p2.Sobrenome = "Vilar";

// // Instanciando a classe Curso
// Curso cursoDeIngles = new Curso();
// cursoDeIngles.Nome = "Ingles";

// // Inicializando a lista de alunos
// cursoDeIngles.Alunos = new List<Pessoa>();

// //Metodo adicionar aluno
// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);

// //Metodo listar alunos
// cursoDeIngles.ListarAlunos();
















// // Instanciando a classe Pessoa
// Pessoa p1 = new Pessoa();

// // Atribuindo valores às propriedades
// p1.Nome = "Leandro";
// p1.Sobrenome = "Vilar";
// p1.Idade = 44;

// // Chamando o método Apresentar
// p1.Apresentar();
