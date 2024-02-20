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
    constructor(nome, peso, altura) {
        this.nome = nome;
        this.peso = peso;
        this.altura = altura;
    };
    calcularImc() {
        return this.peso / (this.altura * this.altura);  // Calculadora de IMC\
    }
    classificarImc() {
        const imc = this.calcularImc();
        if (imc < 18.5) {
            return (" Abaixo do peso")
        } else if (imc >= 18.5 && imc < 25) {
            return ("Peso Nomal");
        } else if (imc >= 25 && imc < 30) {
            return ("Acima Obeso");
        } else if (imc >= 30 && imc < 40) {
            return ("obeso");
        } else {
            return ("Obesidade Grave");
        }

    }
}
const jose = new Pessoa("José", 70, 1.75); //Dados de José

console.log(jose); // Dados de José
console.log(jose.calcularImc()); // Calculadora de IMC
console.log(jose.classificarImc());