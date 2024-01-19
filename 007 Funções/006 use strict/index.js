/*
O strict pode elimina alguns erros silenciosos que passariam batitos do javacript e os faz emitit erros.

Além disso, essa forma corrige alguns erros que tornam o javacript dificio de ser otimizado, então algumas vezes os códigos no modo estrito rodam mais otimizados e velozes do que os códigos no 'modo normal'.

link: http://www.geeksforgeeks.org/strict-mode-javascript/
*/

/*
No seu código, você está tentando atribuir um valor à variável teste sem declará-la previamente e sem utilizar a palavra-chave var, let, ou const. Quando você está utilizando o modo estrito "use strict", esse tipo de comportamento é proibido, e uma exceção será lançada.

Vamos corrigir o código adicionando uma declaração var, let, ou const para a variável teste:

A palavra-chave let e const são introduzidas no ECMAScript 6 (ES6) e são preferíveis ao uso de var em muitas situações, pois proporcionam um escopo de bloco mais preciso. Se possível, opte por let ou const dependendo dos requisitos do seu código.
*/

"use strict";

(() => {
    let teste = "teste"
    console.log(teste);
})();
