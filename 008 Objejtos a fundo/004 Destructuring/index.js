const Tenis = {
    tamanho: 45,
    estoque: true,
    //marcas: [{ nome: "Nike" }, { nome: "Adidas" }],
    secret: 123456,
    n: 5, 
};

//const {tamanho, estoque, marcas = "Nao possui Marca alguma!"} = Tenis;
//console.log(tamanho, estoque, marcas);

const { secret: randomNumber, n: avaliacoes} = Tenis; //dados ocultos
//console.log(secret);
//console.log(randomNumber);
//console.log(avaliacoes);

//pegar dados dentro de outro objetos

const DadosDentroDeDados ={
    link: {a: 1, b: {c:"C"}},
};

const {link} = DadosDentroDeDados;
console.log(DadosDentroDeDados.link.a);
