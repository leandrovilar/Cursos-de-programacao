"use strict";
/*
textContent => retorna o text COM formataçoes, mas sem o elementos
innerText => Retorna somente o texto, sem formatação ou elemento
*/

const p = document.querySelector("p");

console.log(p.textContent);
console.log(p.innerText);

p.textContent = "Leandro Vilar"
p.innerText = "Leandro Vilar"