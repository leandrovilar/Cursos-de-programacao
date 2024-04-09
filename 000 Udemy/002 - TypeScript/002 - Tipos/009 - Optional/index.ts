const fn = (nome: string, idade?: number) => {
    if (!idade){
        return `nome: ${nome}, idade: sem valor defini`;
    }
    return `nome: ${nome}, idade: ${idade}`;
};

console.log(fn("Leandro", 43));
console.log(fn("Leandro"));

const pessoa: {nome: string; idade?: number} = { nome: "Leandro", idade: 43};
