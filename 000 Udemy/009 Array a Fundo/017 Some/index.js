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
        alimento: "Pizza",
        bebida: "Refrigerante",
    },
    {
        id: 22,
        nome: "Sofia",
        alimento: "Pizza",
        bebida: "Refrigerante",
    },
];

//O Some pertunta se apenas 1 dos valores do Array equivale a sua condição


const existeAlimento = pedidos.some((element, index)  => {
    return element.alimento === "Pizza";

    });

    console.log(existeAlimento);
