"use strict";

const menu = document.querySelector("#menu");

menu?.addEventListener("click", (event) => { // ? depoisda menu faz com que o processo continui mesmo nao tendo um referencia no html
    const { target } = event;
    const body = document.querySelector("body");

    switch (target.getAttribute("class")) {
        case "home":
            body.style.background = "blue";
        break;

        case "sobre":
            body.style.background = "red";
        break;

        case "contato":
            body.style.background = "green";
        break;
           
    }
});