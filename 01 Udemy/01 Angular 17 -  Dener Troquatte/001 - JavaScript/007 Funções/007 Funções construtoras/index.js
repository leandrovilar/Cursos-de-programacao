/*ChatGPT
As funções construtoras em JavaScript são utilizadas para criar e inicializar objetos. Elas são chamadas de "construtoras" porque são frequentemente usadas com o operador new para criar instâncias de objetos. Vamos criar um exemplo básico de uma função construtora:
*/
/*
function Pessoa(nome, idade) {
    // Propriedades da instância (variáveis de objeto)
    this.nome = nome;
    this.idade = idade;

    // Método da instância
    this.apresentar = function () {
        console.log(`Olá, eu sou ${this.nome} e tenho ${this.idade} anos.`);
    };
}

// Criando uma instância da função construtora
let pessoa1 = new Pessoa('João', 30);

// Acessando propriedades e chamando métodos
console.log(pessoa1.nome); // João
console.log(pessoa1.idade); // 30
pessoa1.apresentar(); // Olá, eu sou João e tenho 30 anos.
*/
/*
No exemplo acima:

Pessoa é a função construtora.
nome e idade são parâmetros da função construtora, que são utilizados para inicializar as propriedades do objeto.
this se refere à instância do objeto sendo criado. As propriedades e métodos são adicionados a essa instância.
new Pessoa('João', 30) cria uma nova instância da função construtora, atribuindo valores aos parâmetros nome e idade.
É importante notar que, ao usar uma função construtora, cada instância terá suas próprias cópias dos métodos. Se houver muitas instâncias, isso pode consumir mais memória. Uma abordagem mais eficiente é adicionar métodos ao protótipo da função construtora para que todas as instâncias possam compartilhá-los:
*/
/*
function Pessoa(nome, idade) {
    this.nome = nome;
    this.idade = idade;
}

// Adicionando método ao protótipo
Pessoa.prototype.apresentar = function () {
    console.log(`Olá, eu sou ${this.nome} e tenho ${this.idade} anos.`);
};

let pessoa1 = new Pessoa('João', 30);
let pessoa2 = new Pessoa('Maria', 25);

pessoa1.apresentar(); // Olá, eu sou João e tenho 30 anos.
pessoa2.apresentar(); // Olá, eu sou Maria e tenho 25 anos.
*/
/*
Essa abordagem melhora a eficiência do uso de memória, já que todos os objetos compartilham a mesma instância do método no protótipo, em vez de terem cópias individuais.
*/

// Udemy

function Calculadora() {
    this.soma = (num1, num2) => {
        return `${num1 + num2}`;
    };

    this.subtracao = (num1, num2) => {
        return `${num1 - num2}`;
    };
}
const calculadora = new Calculadora();

console.log(calculadora.soma(1, 2));
console.log(calculadora.subtracao(5, 1));

// chatGPT

function Calculadora() {
    this.soma = (num1, num2) => {
        return num1 + num2;
    };

    this.subtracao = (num1, num2) => {
        return num1 - num2;
    };
}

const minhaCalculadora = new Calculadora();

console.log(minhaCalculadora.soma(5, 2));
console.log(minhaCalculadora.subtracao(5, 9));

