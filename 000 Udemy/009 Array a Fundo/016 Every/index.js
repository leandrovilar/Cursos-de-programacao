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

// Trata todo o Array e verifica se está ok

const tenRefri = pedidos.every((element) =>{
    return element.bebida === "Refrigerante";
    });

    console.log(tenRefri);
