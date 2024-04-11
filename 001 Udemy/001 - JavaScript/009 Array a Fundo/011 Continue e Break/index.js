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

for (let item of myArrayObj) {
if (item.nome === "Sofia"){
    console.log("Amor do paizão")
    continue // comando continuar que ler o console.log e não o conteudo do objeto e pula para o próximo
}

if (item.nome === "Marlene"){
    console.log("Minha Namorada")
    break;
}
console.log (item);
}