/*
Classes, métodos e campos no Typescript podem ser abstratos.

Um método abstrato ou campo abstrato é aquele que não teve uma implementação fornecida.
O papel das classes abstratas é servir como uma classse base para subclasses que implementam todos os menbros abstratos.

Quando uma classe nao possui membros abstratos, ela é chamada de concreta.
*/

abstract class Pessoa {
    public nome: string = "";
    public idade: number = 0;

    constructor(nome: string, idade: number) {
        this.nome = nome;
        this.idade = idade;
    }
    public comer(comida: string) {
        return `O ${this.nome} comeu ${comida}`
    }

    public fezAniversario() {
        return `O ${this.nome} fez tantos anos ${++this.idade}`;
    }

    protected abstract profissao: string;
    public abstract qualSuaProfissao(): string;
    public abstract qualSeuSalario(salario: number): number;
}


class Leandro extends Pessoa {
    protected profissao: string = "Programador";
    constructor() {
     super("Leandro", 44)
    }
    public qualSuaProfissao(): string {
        return `Sua Profissao é ${this.profissao}`;
    }

    public qualSeuSalario(salario: number): number {
        return salario;
    }
}
const leandro = new Leandro();
console.log(leandro.qualSuaProfissao());





