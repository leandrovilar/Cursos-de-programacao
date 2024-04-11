"use strict";

const ul = document.querySelector("ul");
const fragment = document.createDocumentFragment();

const lanches = ["lanche 1", "lanche e", "lanche 3", "lanche 4", "lanche 5",];

lanches.forEach((Element) => {
    const li = document.createElement("li");
    li.textContent = Element;
    fragment.append(li);
});

ul.append(fragment);