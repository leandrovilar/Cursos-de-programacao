"use strict";

const btn = document.querySelector("button");
const body = document.querySelector("body");

btn.addEventListener("click", (Event) =>{
    body.style.background = "red";
});

btn.addEventListener("mouseleave", (Event) => {
    body.style.background = "#FFF";
});