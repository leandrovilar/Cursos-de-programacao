//Aula 1 - Estutura Básica

// const leandro = {
//     nome: 'Leandro Vilar',
//     idade: 43
// };

// console.log(leandro.nome);
// console.log(leandro.idade);

// console.log(leandro)

// Aula 2 - Editando informações de um objeto

// const leandro = {
//     nome: 'Leandro Vilar',
//     idade: 43
// };

// leandro.altura = 1.80; // informacoes
// delete leandro.nome; // informacoes

// console.log (leandro);

// Aula 3 - Criando métodos para o objeto

// const pessoa = {
//     nome: 'Leandro Vilar',
//     idade: 43,
//     descrever: function () {
//         console.log(`Meu nome é ${this.nome} e minha idade é ${this.idade}`);
//     }
// };

// // pessoa.nome = 'Marlene';
// // pessoa.idade = 44;
// pessoa.descrever();

// Aula 4 - Acesando Dinamicamente valores de um objeto

const pessoa = {
        nome: 'Leandro Vilar',
        idade: 43,
        descrever: function () {
            console.log(`Meu nome é ${this.nome} e minha idade é ${this.idade}`);
        }
    };
    
    // pessoa.nome = 'Marlene';
    // pessoa.idade = 44;
    pessoa.descrever();
