/*
Uma sala contem 5 alunos e para cada aluno foi sorteado um número de 1 a 100.
Faça um programa que recebe os 5 números sorteados para os alunos e mostre o maior número sorteado.

dados de entrada:
5, 50, 10, 98, 23

saida de dados;
98
*/

const { gets, print } = require('./funcoes');

const numerosSorteados = [];

for (let i = 0; i <5; i++) {
    const nuerosSorteados = gets();
    nuerosSorteados.push(nuerosSorteados);
   }
let maiorValor = 0
for (let i = 0; i <numerosSorteados.length; i++) {
    const numerosSorteados = numerosSorteados[i];
    if (numerosSorteados > maiorValor){
        maiorValor = numerosSorteados;
    }
    
}

print(maiorValor);