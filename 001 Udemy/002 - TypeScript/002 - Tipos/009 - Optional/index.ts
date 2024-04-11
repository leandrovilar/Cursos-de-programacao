const fn = (nome: string, idade?: number) => {
    if (!idade){
        return `nome: ${nome}, idade: sem valor defini`;
    }
    return `nome: ${nome}, idade: ${idade}`;
};

console.log(fn("Leandro", 43));
console.log(fn("Leandro"));

const pessoa: {nome: string; idade?: number} = { nome: "Leandro", idade: 43};

// Este código em TypeScript define uma função chamada fn e uma constante chamada pessoa. Vou explicar linha por linha:
// const fn = (nome: string, idade?: number) => {: Aqui é definida uma função chamada fn que recebe dois parâmetros: nome, que é uma string, e idade, que é um número opcional. Isso significa que idade pode ser fornecido ou não ao chamar a função.
// if (!idade){: Esta linha verifica se o parâmetro idade não foi fornecido. Se idade não for fornecido (ou seja, for undefined), o bloco de código dentro deste if será executado.
// return nome: ${nome}, idade: sem valor defini;: Aqui a função retorna uma string formatada com o nome e uma mensagem indicando que a idade não foi definida.
// return nome: ${nome}, idade: ${idade};: Se a idade for fornecida, a função retorna uma string formatada com o nome e a idade fornecidos.
// console.log(fn("Leandro", 43));: Aqui a função fn é chamada duas vezes: na primeira vez com dois argumentos (nome e idade), e na segunda vez com apenas o argumento do nome. O resultado dessas chamadas será impresso no console.
// console.log(fn("Leandro"));: Aqui a função fn é chamada apenas com o argumento do nome, então a idade será undefined, e a função retornará uma string indicando que a idade não foi definida.
// const pessoa: {nome: string; idade?: number} = { nome: "Leandro", idade: 43};: Aqui é definida uma constante chamada pessoa. Esta constante é um objeto com duas propriedades: nome, que é uma string, e idade, que é um número opcional. Neste caso, tanto o nome quanto a idade estão definidos.
// Resumidamente, a função fn aceita um nome e uma idade opcional como parâmetros e retorna uma string formatada com esses valores. A constante pessoa é um objeto que representa uma pessoa com um nome e uma idade.