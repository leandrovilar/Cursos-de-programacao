using ExemploExplorando.Models; // Certifique-se de incluir a namespace correta


// Instanciando a classe Pessoa
Pessoa p1 = new Pessoa();
// Atribuindo valores às propriedades
p1.Nome = "Leandro";
p1.Sobrenome = "Vilar";

// Instanciando a classe Pessoa
Pessoa p2 = new Pessoa();
// Atribuindo valores às propriedades
p2.Nome = "Renata";
p2.Sobrenome = "Vilar";

// Instanciando a classe Curso
Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

//Metodo adicionar aluno
cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
//Metodo listar alunos
cursoDeIngles.ListarAlunos();
















// // Instanciando a classe Pessoa
// Pessoa p1 = new Pessoa();

// // Atribuindo valores às propriedades
// p1.Nome = "Leandro";
// p1.Sobrenome = "Vilar";
// p1.Idade = 44;

// // Chamando o método Apresentar
// p1.Apresentar();
