const pedidos = [
    {
        id: 420,
        nome: "Leandro",
        alimento: "Sanduiche",
        bebida: "suco",
    },
    {
        id: 152,
        nome: "Leandro",
        alimento: "Sanduiche",
        bebida: "suco",
    },
    {
        id: 200,
        nome: "Renata",
        alimento: "Sanduiche",
        bebida: "suco",
    },
    {
        id: 33,
        nome: "Marlene",
        alimento: "Sanduiche",
        bebida: "Refrigerante",
    },
    {
        id: 22,
        nome: "Sofia",
        alimento: "Sanduiche",
        bebida: "Refrigerante",
    },
];

//Nome bem subjetivo também, mas ele procura e te retorna 1 o primeiro valor encontradao do Array

const findId = pedidos.filter((element) => {
    return element.id === 33;
})

console.log (findId);