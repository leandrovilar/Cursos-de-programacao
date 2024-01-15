/*
Precisamos mostrar a tabuada no console de 0 ate 10 neste seguinte formamdo:

multiplicador x nuemro = resultado
multiplicador x 0 = resultado
multiplicador x 1 = resultado
multiplicador x 2 = resultado
multiplicador x 3 = resultado

Obs.: Nao podemso criar vairos consoles.log (multiplicador x 3 = resultado)

*/

const multiplicador = 9;

// let i = 0

for (let i = 0; i <= 10; i++){
    const calc = multiplicador * i;
    console.log (`${multiplicador} x ${i} = ${calc}`);
}