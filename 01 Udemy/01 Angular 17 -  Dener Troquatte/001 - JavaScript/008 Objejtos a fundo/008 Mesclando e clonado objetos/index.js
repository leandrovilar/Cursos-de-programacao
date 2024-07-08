// Para mesclar (combinar) ou clonar objetos em JavaScript, existem várias abordagens. Vou mostrar algumas maneiras comuns de realizar essas operações:

// ### Mesclando (Combinação) de Objetos:

// 1. **Object.assign:**
//    O método `Object.assign` pode ser usado para mesclar propriedades de vários objetos em um objeto de destino.

//     ```javascript
//     let objetoAlvo = { a: 1, b: 2 };
//     let objetoOrigem = { b: 3, c: 4 };

//     // Mesclar objetoOrigem em objetoAlvo
//     Object.assign(objetoAlvo, objetoOrigem);

//     console.log(objetoAlvo);
//     ```

//    O resultado será `{ a: 1, b: 3, c: 4 }`.

// 2. **Spread Operator (ES6):**
//    O operador de propagação (`...`) também pode ser usado para mesclar objetos.

//     ```javascript
//     let objetoAlvo = { a: 1, b: 2 };
//     let objetoOrigem = { b: 3, c: 4 };

//     // Mesclar objetoOrigem em objetoAlvo usando spread operator
//     let objetoMesclado = { ...objetoAlvo, ...objetoOrigem };

//     console.log(objetoMesclado);
//     ```

//    O resultado será `{ a: 1, b: 3, c: 4 }`.

// ### Clonando Objetos:

// 1. **Object.assign (Clonagem Superficial):**
//    O `Object.assign` também pode ser usado para criar uma cópia superficial de um objeto.

//     ```javascript
//     let objetoOriginal = { a: 1, b: 2 };
//     let objetoClone = Object.assign({}, objetoOriginal);

//     console.log(objetoClone);
//     ```

//    Isso cria um novo objeto (`objetoClone`) com as mesmas propriedades e valores do objeto original, mas eles não compartilham referências.

// 2. **Spread Operator (ES6 - Clonagem Superficial):**
//    O operador de propagação também pode ser usado para criar uma cópia superficial.

//     ```javascript
//     let objetoOriginal = { a: 1, b: 2 };
//     let objetoClone = { ...objetoOriginal };

//     console.log(objetoClone);
//     ```

//    Isso cria um novo objeto (`objetoClone`) de forma semelhante ao `Object.assign`.

// 3. **JSON.parse e JSON.stringify (Clonagem Profunda):**
//    Para realizar uma clonagem profunda (incluindo objetos aninhados), você pode usar `JSON.parse` e `JSON.stringify`.

//     ```javascript
//     let objetoOriginal = { a: 1, b: { c: 2 } };
//     let objetoClone = JSON.parse(JSON.stringify(objetoOriginal));

//     console.log(objetoClone);
//     ```

//    Esta abordagem tem limitações (por exemplo, ela não lida bem com funções ou objetos que têm referências circulares), mas funciona para muitos casos.

// Escolha a abordagem que melhor se adapte às suas necessidades com base nos requisitos específicos do seu código.

// Aula

let Tenis = {
    tamanho: 45,
    estoque: true,
};

let link = { link: { a: "A", b: { c: "C" } } };

let clone1 = Tenis;
let mescla1 = Object.assign(Tenis, link);
let mesclar2 = {...Tenis, ...link};

console.log(clone1);

clone1.estoque = false
mesclar1.link = "ABC" // clone e mesclagem de objetos rasos

console.log(mescla1);
console.log(mescla2);
console.log (Tenis)


