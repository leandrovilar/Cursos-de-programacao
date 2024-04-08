//Array
let array1: [string, string, number, boolean] = ["Leandro Vilar", "teste", 123, false] // dessa forma só da para colocar o que for pedido no array
let array2: Array<string | number | boolean> = ["Leandro Vilar", "teste", 123, false] // dessa formar pode ser colocado varias argumentos 

//Object
let obj1: {nome: string; sobrenome: string; idade: number; deuBom: boolean} = { nome: "Leandro", sobrenome: "Vilar", idade:123, deuBom: true};

let obj2: Array<{nome: string; sobrenome: string; idade: number; deuBom: boolean}> = [{nome: "Leandro", sobrenome: "Vilar", idade:123, deuBom: true,},];




console.log(array1);
console.log(array2);
console.log(obj1);
console.log(obj2);