// DIO FUNÇÃO

function calcularIMC(peso, altura) {
    return peso / Math.pow(altura, 2);
}

function classificarImc(imc) {

    if (imc < 18.5) {
        return (" Abaixo do peso")
    } else if (imc >= 18.5 && imc < 25) {
        return ("Peso Nomal");
    } else if (imc >= 25 && imc < 30) {
        return ("Acima Obeso");
    } else if (imc >= 30 && imc < 40) {
        return ("obeso");
    } else {
        return ("Obesidade Grave");
    }
}

function main(){
    const peso = 85;
    const altura = 1.80;
    
    const imc = calcularIMC (peso, altura);
    
    console.log(imc);
    console.log(classificarImc(imc));
}
main();

