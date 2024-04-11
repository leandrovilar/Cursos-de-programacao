"use strict";

const form = document.forms.namedItem("select-checkbox");
const submit = document.querySelector("#submit");
const chage = document.querySelector("change");

let checkedValues = [];

form.addEventListener("submit", (event) => {
    event.preventDefault();
    submit.innerHTML = checkedValues;
});

form.checbox.forEach(element => {
    element.addEventListener("change", (event) => {
        hasChecked(event, element);
        Change.innerHTML = checkedValues;
    });
});

const hasChecked = (event, element) => {
    const { target } = event;

    if (target.checked) {
        return checkedValues.push(element.value);
    }
    if (!target.checked) {
        return checkedValues.map((checkedValues, index) => {
            if (element.value === checkedValues) {
                return checkedValues.splice(index, 1);
            }
        })
    }
}

