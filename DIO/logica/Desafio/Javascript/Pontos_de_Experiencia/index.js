//Desafios JavaScript na DIO têm funções "gets" e "print" acessíveis globalmente:
//- "gets" : lê UMA linha com dado(s) de entrada (inputs) do usuário;
//- "print": imprime um texto de saída (output), pulando linha.

// Entrada de dados. Lembre-se: O parseInt(()) é importante para a conversão dos valores de entrada(String) para um valor numérico(int).

let num1 = parseInt(gets());
let num2 = parseInt(gets());

const xpGanho = (num1 * num2) * 100; 

console.log("Você ganhou " + xpGanho + " XP!");
alert("Você ganhou " + xpGanho + " XP!");