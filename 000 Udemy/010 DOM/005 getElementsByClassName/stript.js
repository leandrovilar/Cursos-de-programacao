"use strict";
// pega todos os elementos da class com um nome especifico

const p = document.getElementsByClassName("paragrafo");

console.log(p);

for (let element of p){
    console.log(element);
}