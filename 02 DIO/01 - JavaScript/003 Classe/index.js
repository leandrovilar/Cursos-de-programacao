// Auda 1 - Classe e instância

// Classe
// class Pessoa {
//     nome;
//     idade;

//// para descrever metodo não precisa da palabra function em uma function
//     descrever() {
//         console.log(`Meu nome é ${this.nome} e minha idade é ${this.idade}`);
//     }
// }
// // uma instância é um ocorrência da classe Pessoa
// const leandro = new Pessoa();
// leandro.nome = `Leandro Vilar`;
// leandro.idade = 43;

// const marlene = new Pessoa();
// marlene.nome = `Marlene Rodrigues`;
// marlene.idade = `44`;

// console.log(leandro);
// console.log(marlene);

// leandro.descrever();
// marlene.descrever();


// Aula 2 - Como criar instacias com contrutor 

class Pessoa {
    nome;
    idade;
    anoDeNascimento;

    constructor(nome, idade) {
        this.nome = nome;
        this.idade = idade;
        this.anoDeNascimento = 2024 - idade;
    }
    descrever() {
        console.log(`Meu nome é ${this.nome} e minha idade é ${this.idade}`);
    }
}


const leandro = new Pessoa(`Leandro Vilar`, 43);
console.log(leandro);
leandro.descrever();
