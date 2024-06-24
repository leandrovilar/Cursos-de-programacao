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
Este é um código em TypeScript que define uma classe chamada `Utils` com um método estático chamado `cloneObject`. Este método recebe um array de objetos como parâmetro e retorna uma cópia profunda (deep copy) desse array de objetos.

Aqui está uma explicação linha por linha do código:

1. `class Utils {`: Define uma classe chamada `Utils`.

2. `static cloneObject(object: Array<{}>) {`: Define um método estático chamado `cloneObject` na classe `Utils`. Este método recebe um parâmetro `object` que é um array de objetos, onde cada objeto pode ter qualquer estrutura.

3. `return JSON.parse(JSON.stringify(Object.assign(object)));`: Esta linha faz a cópia profunda do array de objetos. O `Object.assign()` é usado para criar uma cópia superficial (shallow copy) do array, o `JSON.stringify()` converte essa cópia superficial em uma string JSON, e `JSON.parse()` converte essa string JSON de volta em um objeto JavaScript, resultando em uma cópia profunda.

4. `};`: Fecha o método `cloneObject` e a classe `Utils`.

5. `const tenis1: { tamanho: number; estoque: boolean; } = {`: Define uma constante chamada `tenis1` que é um objeto com as propriedades `tamanho` e `estoque`.

6. `console.log(Utils.cloneObject([tenis1,tenis2]));`: Chama o método `cloneObject` da classe `Utils`, passando um array contendo `tenis1` e `tenis2` como argumentos, e imprime o resultado no console.

Em resumo, o código cria uma cópia profunda de um array de objetos usando o método `cloneObject` da classe `Utils`. Isso garante que a cópia seja independente do objeto original, ou seja, qualquer modificação feita na cópia não afetará o objeto original e vice-versa.
*/

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