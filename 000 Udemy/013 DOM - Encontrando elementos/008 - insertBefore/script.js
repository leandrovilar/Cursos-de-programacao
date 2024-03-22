"use strict";

const container = document.querySelector(".containe");
const paragrafo = document.querySelector("#paragrafo");
const h1 = documet.querySelector("h1");

const newH2 = document.createElement("h2");
newH2.innerText = "Novo H2";

container.insertBefore(newH2, paragrafo);
