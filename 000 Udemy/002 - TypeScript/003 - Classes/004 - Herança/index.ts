/*
public - Pode seu acesado tanto pela mesma classe, 
        classe filhas e outras classes.
--------------------------------------------------------------------
Protected - pode ser acesssado pela mesma classe e classes filhas,
            nao pode ser acessado por outras classes.
--------------------------------------------------------------------
Private - Pode ser acessada somente pela própria classe.
*/

class Pessoa {
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
}

//modelo 1
class Leandro extends Pessoa {
    private profissao: string = "Programador"
    constructor() {
        super("Leandro", 44)
    }
    public getProfissao() {
        return `${this.nome} Trabalha como ${this.profissao}`;
    }
}
const leandro = new Leandro(); //modelo 1

// //modelo 2
// class Marlene extends Pessoa{}
// const marlene = new Marlene("Marlene Rodrigues", 45); // modelo 2

console.log(leandro.getProfissao());


