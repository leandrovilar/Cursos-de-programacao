const myArrayObj = [
    {
        nome: "Leandro",
        sobrenome: "Vilar"
    },
    {
        nome: "Sofia",
        sobrenome: "Vilar"
    },
    {
        nome: "Marlene",
        sobrenome: "Rodrigues"
    },
    {
        nome: "Renata",
        sobrenome: "Vilar"
    },
];

myArrayObj.forEach((item, index) => {
    if (item.nome === "Sofia"){
        return console.log("O amorzinho do papai");
    }
});