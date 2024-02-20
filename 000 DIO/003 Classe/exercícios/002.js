/*
Exercício 02
Crie uma classe para representar pessoas.
Para cada pessoa teremos os acrigutos nome, peso e altura.
As pessoas devem ter a capacidade de dizer o valor do IMC (IMC = peso / (altura*altura));
Instancia uma pessoa chamada Jose que tenha 70kg de peso e 1,75 de altura e peça pao José
para dizer o valor do seu IMC;
*/


class Pessoa {
    nome;
    peso;
    altura;
constructor (nome, peso, altura){
    this.nome = nome;
    this.peso = peso;
    this.altura = altura;
};
calcularImc(){
    return this.peso / (this.altura * this.altura);  // Calculadora de IMC
}
}
const jose = new Pessoa ("José", 70, 1.75); //Dados de José

console.log (jose); // Dados de José
console.log (jose.calcularImc()); // Calculadora de IMC