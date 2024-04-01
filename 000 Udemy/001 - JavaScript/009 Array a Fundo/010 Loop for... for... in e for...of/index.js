

// for ([inicialização]; [condição]; [expressão])

// básico de for
// for (let i = 0; i <=10; i++){
//     console.log(i);
// }

// for modelo 1
const myArray = [1,2,3,4,5,6];

// for (let i = 0; i < myArray.length; i++){
//     console.log(myArray[i]);
// }

//for modelo 2
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
        nome: "Renata",
        sobrenome: "Vilar"
    },
    
];
//for modelo 2
// for (let i = 0; i < myArrayObj.length; i++){
//     console.log(myArrayObj[i].nome, myArrayObj[i].sobrenome);
// }

// For of
// 01 - modelo
// for (let item of myArrayObj) {
//     console.log(item.nome, item.sobrenome);
// }
// // 02 - modelo 
// for (let item of myArray) {
//     console.log(item);
// }

//For in (trabalha com objeto)
const obj = {nome: "Leandro", sobrenome: "Vilar"};

for (let item in obj){
    console.log(obj[item])
}
