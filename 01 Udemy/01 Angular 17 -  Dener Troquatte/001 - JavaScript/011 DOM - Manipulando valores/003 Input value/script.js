"use strict";

const input = document.querySelector( "#name");

console.log (input.value);

setTimeout(() => {
    input.value = "Banana";
    console.log (input.value);
}, 1000);