/* //Aula do curso

class Pessoa {
    public readonly nome: string = "Leandro Vilar";
}

let pessoa = new Pessoa();

console.log(pessoa.nome);
pessoa.nome = "Gostosão"; // Não é possivel atribuir
console.log(pessoa.nome);
*/


// Em TypeScript, a palavra-chave `readonly` é usada para definir propriedades de um objeto que não podem ser modificadas após sua inicialização. Isso significa que uma vez que o valor de uma propriedade é atribuído, ele não pode ser alterado posteriormente.

/*
// Aqui está um exemplo simples do chatGPT:
class Pessoa {
    readonly nome: string;

    constructor(nome: string) {
        this.nome = nome;
    }
}

let pessoa = new Pessoa("João");
console.log(pessoa.nome); // Saída: João

// Tentativa de modificar o nome, resultará em um erro
pessoa.nome = "Maria"; // Erro: Cannot assign to 'nome' because it is a read-only property

*/

// Neste exemplo, a propriedade `nome` da classe `Pessoa` é declarada como `readonly`, o que significa que seu valor só pode ser atribuído uma vez, dentro do construtor da classe. Qualquer tentativa de modificá-lo fora do construtor resultará em um erro de compilação. Isso é útil quando você quer garantir que certos valores não sejam alterados após a inicialização do objeto, o que pode ajudar a evitar bugs difíceis de rastrear em seu código.