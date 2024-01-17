/*
Hoisting é um comportamento em JavaScript em que as declarações de variáveis e funções são movidas para o topo de seu contexto de execução durante a fase de compilação. Isso significa que, mesmo que você declare variáveis ou funções em locais específicos no código, elas podem ser utilizadas antes de sua declaração real no código. No entanto, é importante notar que apenas as declarações são elevadas, não as inicializações.

Vamos ver alguns exemplos para entender melhor o hoisting:

Hoisting de Variáveis:
javascript
Copy code
console.log(x); // undefined
var x = 5;
console.log(x); // 5
O código acima é interpretado como:

javascript
Copy code
var x;
console.log(x); // undefined
x = 5;
console.log(x); // 5
Hoisting de Funções:
javascript
Copy code
hoistedFunction(); // "Hello, World!"

function hoistedFunction() {
  console.log("Hello, World!");
}
Neste exemplo, a função hoistedFunction é chamada antes da sua declaração no código. Isso é possível devido ao hoisting.

Entretanto, é importante notar que apenas a declaração da função é elevada, não a atribuição de função a uma variável (caso esteja sendo atribuída). Por exemplo:

javascript
Copy code
// Isso não funcionará como esperado
console.log(myFunction); // undefined
var myFunction = function() {
  console.log("Hello!");
};
Neste caso, apenas a declaração da variável myFunction é hoisted, não a atribuição da função.

Em resumo, embora o hoisting possa facilitar a escrita de código em alguns casos, é recomendável manter a ordem lógica das declarações para tornar o código mais legível e evitar comportamentos inesperados. É uma boa prática declarar variáveis no início de uma função ou bloco e definir funções antes de chamá-las.
*/