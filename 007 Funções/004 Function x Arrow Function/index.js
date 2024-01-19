
//1 Nome da função 

//modelo 01
function nomeFunc() {
    return "Nome da função";
}
console.log(nomeFunc());

//modelo 02
const nomeFuncArrow = () => {
    return "Nome da function Arrow"
}
console.log(nomeFuncArrow());

// modelo 03 somente para um parametro
const nomeFuncArronwParams = param => param;

// Retorno 
const nomeFuncArrowReturn = () => "Nome da function arrow return";
console.log(nomeFuncArrowReturn());

// Não tem hoisting (não funciona com Arrow )
const nomeFuncArrowHoisting = () => {
    return "Nome da function arrow hoisting"
}
console.log(nomeFuncArrowHoisting());

//tem hoisting
console.log(nomeFuncHosting());
function nomeFuncHosting() {
    return "Nome da função que tem hosting";
}

// arguments

/* Funciona */
function nomeFuncArguments() {
    return arguments;
}
console.log(nomeFuncArguments("arguments"))


/* nao funciona Arrow
 
const nomeFuncArrowArguments = () => {
return arguments;
}
console.log(nomeFuncArrowArguments())

*/




//5 Nao pode ser invocadaco New

function novaFunc() {
    //       return console.log (123);
}
new novaFunc();

const novaFuncArrow = () => {
    //       return console.log(123);
}
new novaFuncArrow();

/*
6 - Contexto
Arrow functions possuem this lexico enquanto o modelo normal possui this dinamico.

Isso significa que arrow functions herdam o contexto local de onde foi declarado, enquanto o modelo normal posui o contexto associado ao objeto que ele esta viculado no momento da chama

Se ele nao estiver associado ao ninguem na chamada, ele assumirá this automaticamente como o contexto global, que no caso dos navegadores é window
*/
const lanches = {
    cardapio: [
        { nome: "x-salada", preço: "R$ 25" },
        { nome: "x-bolovo", preço: "R$ 30" },
    ],

    meuPedidoFunc: function (select) {
        return console.log(this.cardapio[select]);
    },

    meuPedidoFuncTimeOut: function () {
        setTimeout(
            function () {
                console.log(this.cardapio);
                console.log(this);
            }.bind(this),
            1000
        );
    },

    meuPedidoArrowFunc: (select) => {
        this.cardapio = [
            { nome: "x-salada", preço: "R$ 45" },
            { nome: "x-bolovo", preço: "R$ 50" },
        ];
        return console.log(this.cardapio[select]);
    },
};



/*
7 - Constructor 
Arrow functions nao podem ser contructors, entao nao e possivel usar o operador new com a mesma.
*/
class newFunc {
    constructor(nome) {
        this.nome = nome;
    }
}

const a = new newFunc("Leandro Vilar");
console.log(a.nome);