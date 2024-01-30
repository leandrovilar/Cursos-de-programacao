/*
function soma(num1, num2) {
    if (typeof num1 === "number" && typeof num2 === "number") {
        return num1 + num2;
    }
    return "Você passou dados diferentes";
}
console.log(soma (1, 5));
*/

// cuidado com arguments

function subtracao(){
    return arguments;
}
console.log(subtracao(1, 2, "äbc"));