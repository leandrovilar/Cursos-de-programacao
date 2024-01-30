// Aula

let Tenis = {
    tamanho: 45,
    estoque: true,
};

let link = { link: { a: "A", b: { c: "C" } } };

let clone1 = Tenis;
console.log(1,clone1);
console.log(2,Tenis);

let mesclar1 = Object.assign(Tenis, link);
let mesclar2 = {...Tenis, ...link};

clone1.estoque = false
mesclar1.link = "ABC"

console.log(3,clone1);
console.log(4,mesclar1);
console.log(5,mesclar2);
console.log (6,Tenis)
