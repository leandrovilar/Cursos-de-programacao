//const stringArray = ["A", "C", "D", "W", "L", "B"];

// console.log(stringArray.sort()); // ordena de frente pra traz
// console.log (stringArray.reverse()); // ordena de traz pra frente

/*
sort((a, b) => a - b));
se retornar um valor negativo, o valor de "a" será ordenado antes de "b".
se retornar 0, a ordenaçao de "a" e "b" não mudará.
se retornar um valor positivo, o valor em "b" será ordenado antes de "a".
*/

const numberArray = [10, 20, 30, 40, 50, 1000, 1, 55, 15];

console.log(numberArray.sort((a, b) => a - b));
console.log(numberArray.sort((a, b) => b - a));
console.log(numberArray.sort((a, b) => a - b).reverse);

const objArray = [
    {
        nome: "Leandro Vilar"
    },
    {
        nome: "Sofia Vilar"
    },
    {
        nome: "Nyzia Vilar"
    },
    {
        nome: "Renata Vilar"
    },
    {
        nome: "José Vilar"
    },
    {
        nome: "Pedro Vilar"
    },
];

console.log(objArray.sort((a, b) => a.nome.localeCompare(b.nome)));
console.log(objArray.sort((a, b) => b.nome.localeCompare(a.nome)));
console.log(objArray.sort((a, b) => a.nome.localeCompare(b.nome)).reverse());