"use strict";

const h1 = document.querySelector("h1"); // tag html5
const classP = document.querySelector(".paragrafo"); 
const ipP = document.querySelector('#paragrafo')

console.log(h1);
console.log(classP); 
console.log(ipP);

let timer = 0;
const title = document.querySelector("title");

setInterval(() => {
    title.innerText = timer;
    timer++;
}, 1000);
