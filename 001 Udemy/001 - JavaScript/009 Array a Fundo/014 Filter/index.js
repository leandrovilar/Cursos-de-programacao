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

//Como o nome ja diz, esse método deve ser ulilizado quando temos a necessidade de filtra nossa lista

const filterRefri = pedidos.filter((element, index) => {
    return element.bebida === "Refrigerante";

});

console.log (filterRefri);
