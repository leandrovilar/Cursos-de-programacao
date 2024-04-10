/*
A palavra chave static defne um metodo estatico para a classe.
Metodos estaticos nao sao chamados na instacias da classe.
Em vez disso, eles sao chamados na propria classe.
Geralmente, sao funcoes utilitarias, como funcoes para criar ou clonar objetos.
*/

class Utils {
    static cloneObject(object: Array<{}>) {
        return JSON.parse(JSON.stringify(Object.assign(object)));
    }
};

const tenis1: { tamanho: number; estoque: boolean; } = {
    tamanho: 41,
    estoque: true,
};

const tenis2: { tamanho: number; estoque: boolean; } = {
    tamanho: 41,
    estoque: true,
};

console.log(Utils.cloneObject([tenis1,tenis2]));


/*
Chatgpt

class Utils {
    static cloneObject(object: Array<{ tamanho: number; estoque: boolean; }>) {
        return JSON.parse(JSON.stringify(Object.assign({}, object)));
    }
};

const tenis1: { tamanho: number; estoque: boolean; } = {
    tamanho: 41,
    estoque: true,
};

const tenis2: { tamanho: number; estoque: boolean; } = {
    tamanho: 41,
    estoque: true,
};

console.log(Utils.cloneObject([tenis1, tenis2]));
*/