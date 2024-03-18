"use strict";

const h1 = document.querySelector("h1");
h1.classList.add("active", "Teste1");
h1.classList.add("teste2");
h1.classList.remove("teste 2");
h1.classList.toggle("teste 2")

if (h1.classList.contains("active")){

}

console.log(h1);