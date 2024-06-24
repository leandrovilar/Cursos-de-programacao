/*
Uma classe Typescript é uma estrutura de progamação orientada a dojetos que possui um conjunto de propriedades e métodos.

Aclasse é um modelo para criar ogjetos, permitindo que você defina uma estrutura com propriedade e comportamentos.
*/

class Pessoa {
    nome: string = "";
    idade: number = 0;

    constructor(nome: string, idade:  number){
        this.nome = nome;
        this.idade = idade;
    }
}

const pessoa1 = new Pessoa ("Leandro Vilar", 44);
const pessoa2 = new Pessoa ("Marlene Rodrigues", 45);

console.log (pessoa1.nome)
console.log (pessoa1.idade)

console.log (pessoa2.nome)
console.log (pessoa2.idade)

/*
Este é um exemplo de código em TypeScript que define uma classe `Pessoa` e cria duas instâncias dessa classe (`pessoa1` e `pessoa2`), cada uma com um nome e uma idade diferentes.

Vou explicar linha por linha:

1. `class Pessoa {`: Aqui, uma classe chamada `Pessoa` é definida.

2. `nome: string = "";`: Aqui, é declarado um atributo `nome` do tipo `string` dentro da classe `Pessoa`, inicializado com uma string vazia.

3. `idade: number = 0;`: Similar ao atributo `nome`, este é um atributo `idade` do tipo `number`, inicializado com o valor `0`.

4. `constructor(nome: string, idade: number) {`: Este é o construtor da classe `Pessoa`, que recebe dois parâmetros: `nome` (do tipo `string`) e `idade` (do tipo `number`).

5. `this.nome = nome;`: Dentro do construtor, o parâmetro `nome` é atribuído ao atributo `nome` da instância atual da classe (`this.nome`).

6. `this.idade = idade;`: Similarmente, o parâmetro `idade` é atribuído ao atributo `idade` da instância atual da classe (`this.idade`).

7. `}`: Fim do construtor.

8. `const pessoa1 = new Pessoa("Leandro Vilar", 44);`: Aqui, uma nova instância da classe `Pessoa` é criada, com o nome "Leandro Vilar" e a idade 44, e atribuída à variável `pessoa1`.

9. `const pessoa2 = new Pessoa("Marlene Rodrigues", 45);`: Similarmente, outra instância da classe `Pessoa` é criada, com o nome "Marlene Rodrigues" e a idade 45, e atribuída à variável `pessoa2`.

10. `console.log(pessoa1.nome)`: Imprime o nome da `pessoa1` no console.

11. `console.log(pessoa1.idade)`: Imprime a idade da `pessoa1` no console.

12. `console.log(pessoa2.nome)`: Imprime o nome da `pessoa2` no console.

13. `console.log(pessoa2.idade)`: Imprime a idade da `pessoa2` no console.

Em resumo, o código cria uma classe `Pessoa` com atributos `nome` e `idade`, e então cria duas instâncias dessa classe (`pessoa1` e `pessoa2`) com valores diferentes para esses atributos. Em seguida, imprime os nomes e idades dessas pessoas no console.
*/