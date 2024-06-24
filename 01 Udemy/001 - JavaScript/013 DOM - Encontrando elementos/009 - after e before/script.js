"use strict";

const container = document.querySelector(".containe");

const newP = document.createElement("p");
newP.innerText = "Olá, Leandro";

container.before("Olá, Leandro");

//container.after(newP);
