/*
1 - Crie uma class para pepresentar carros
Os carros possuem uma marca, uma cor e um gasto médio de combustivel por km rodadeo.
Cri um método que dado a quantidade de km o proço do combustível nos dê o valor gasto 
em reais para realizar este percurso.
*/

// //classe carro
// class Carro {
//     marca;
//     cor;
//     consumo;

//     constructor(marca, cor, consumo) {
//         this.marca = marca;
//         this.cor = cor;
//         this.consumo = consumo;
//     }

//     // criando um metodo que calcule gasto de combustivel
//     calcularGastoDePercurso(distancia, precoCombustivel){
//         return
//     }
// };

// //instancia da class Carro
// const uno = new Carro('kiwd', 'prata', 1/ 18);
// console.log(uno);

class Carro {
    constructor(marca, cor, consumoCombustivel) {
        this.marca = marca;
        this.cor = cor;
        this.consumoCombustivel = consumoCombustivel; // consumo de combustível em km por litro
    }

    calcularCustoCombustivel(distancia, precoCombustivelPorLitro) {
        const combustivelNecessario = distancia / this.consumoCombustivel;
        const custoTotal = combustivelNecessario * precoCombustivelPorLitro;
        return custoTotal;
    }
}

// Exemplo de uso:
const carro1 = new Carro("Toyota", "Azul", 18); // Assumindo consumo de 12 km por litro
const distanciaPercorrida = 1300; // em quilômetros
const precoCombustivel = 5.89; // preço do combustível por litro

const custoViagem = carro1.calcularCustoCombustivel(distanciaPercorrida, precoCombustivel);
console.log(`O custo para uma viagem de ${distanciaPercorrida} km com o carro ${carro1.cor} ${carro1.marca} é: R$${custoViagem.toFixed(2)}`);
