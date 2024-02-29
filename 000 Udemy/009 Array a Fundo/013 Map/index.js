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
        bebida: "suco",
    },
    {
        id: 22,
        nome: "Sofia",
        alimento: "Sanduiche",
        bebida: "suco",
    },
];

pedidos.map((element, index) => {
    if (element.id === 33 && element.alimento === "Sanduiche") {
        return (element.alimento = "kibe");
    }
});

console.log(pedidos);