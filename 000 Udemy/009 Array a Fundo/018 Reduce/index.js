const pedidos = [
    {
        id: 420,
        nome: "Leandro",
        alimento: "Sanduiche",
        bebida: "suco",
        preco: 35
    },
    {
        id: 152,
        nome: "Leandro",
        alimento: "Sanduiche",
        bebida: "suco",
        preco: 55
    },
    {
        id: 200,
        nome: "Renata",
        alimento: "Sanduiche",
        bebida: "suco",
        preco: 90,
    },
    {
        id: 33,
        nome: "Marlene",
        alimento: "Pizza",
        bebida: "Refrigerante",
        preco: 80,
    },
    {
        id: 22,
        nome: "Sofia",
        alimento: "Pizza",
        bebida: "Refrigerante",
        preco: 70,
    },
];

// Pega todos os valores de um Array e condensa em um só

const balancete = pedidos.reduce((total, element) => {
return total + element.preco;
}, 0);

console.log(balancete);
