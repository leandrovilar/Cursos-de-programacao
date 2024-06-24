class Pessoa {
    nome: string = "";
    idade: number = 0;

    constructor(nome: string, idade: number) {
        this.nome = nome;
        this.idade = idade;
    }
    comer(comida: string) {
        return `O ${this.nome} comeu ${comida}`
    }

    fezAniversario(){
        return `O ${this.nome} fez tantos anos ${++this.idade}`;
    }
}

const pessoa1 =new Pessoa("Leandro Vilar", 43);
console.log(pessoa1.comer("Feijoada"));
console.log(pessoa1.fezAniversario());


const pessoa2 =new Pessoa("Marlene Rodrigues", 45);
console.log(pessoa2.comer("torta"));
console.log(pessoa2.fezAniversario());