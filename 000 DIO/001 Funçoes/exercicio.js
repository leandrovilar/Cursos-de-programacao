/*
function ecrevaMeuNome(nome) {
    console.log ('Meu nome é ' + nome)
}
ecrevaMeuNome('Leandro Vilar')
*/

// funcao para saber se a pessoa é maior de idade
/*function minhaIdade(idade) {
    if (idade >= 18) {
        console.log('Maior de idade');
    } else {
        console.log('menor de idade')
    }
}
minhaIdade(3);
*/

// 03 chamar 2 funcoes 
/*function ecrevaMeuNome(nome) {
    return ('Meu nome é ' + nome);
}

function minhaIdade(idade) {
    if (idade >= 18) {
        console.log(ecrevaMeuNome('Leandro Vilar ') + 'Maior de idade');
    } else {
        console.log('menor de idade')
    }
}
minhaIdade(18);
*/

// 04 Exercicios
/*
Codito condicao de pagamento:
1 - A vista debito, recebe 10% de desconto;
2 - A vista no dinheiro ou pix, recebe 15% de desconto;
3 - Em duas vezes, preço normal de etiqueta sem juros;
4 - Acima de duas vezes, preço normal de etiqueta mais juros de 10%;
*/

function aplicarDesconto(valor, desconto) {
    return (valor - (valor * (desconto / 100)));
}
function aplicarJuros(valor, juros) {
    return (valor + (valor * (juros / 100)));
}

const precoEtiqueta = 100;
const formaDePagamento = 4;

if (formaDePagamento === 1) {
    console.log(aplicarDesconto(precoEtiqueta, 10));
} else if (formaDePagamento === 2) {
    console.log(aplicarDesconto(precoEtiqueta, 15));
} else if (formaDePagamento === 3) {
    console.log(precoEtiqueta);
} else {
    console.log(aplicarJuros(precoEtiqueta, 10));
}