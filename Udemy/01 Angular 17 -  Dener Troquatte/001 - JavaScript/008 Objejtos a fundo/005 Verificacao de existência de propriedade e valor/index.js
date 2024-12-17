//chatGPT
// Ao verificar a existência de uma propriedade em um objeto e também validar o valor associado a essa propriedade, você pode usar uma combinação de técnicas em JavaScript. Aqui estão algumas maneiras de realizar isso:

// ### Verificação de Existência de Propriedade:

// 1. **Operador `in`:**
//    O operador `in` verifica se uma propriedade está presente no objeto, incluindo propriedades na cadeia de protótipos.

//     ```javascript
    const meuObjeto1 = { nome: 'João', idade: 25 };

    if ('nome' in meuObjeto1) {
        console.log('A propriedade "nome" existe no objeto.');
    }
//     ```

// 2. **Método `hasOwnProperty`:**
//    O método `hasOwnProperty` verifica se uma propriedade pertence diretamente ao objeto, excluindo propriedades na cadeia de protótipos.

//     ```javascript
    const meuObjeto2 = { nome: 'Maria', idade: 30 };

    if (meuObjeto2.hasOwnProperty('nome')) {
        console.log('A propriedade "nome" existe no objeto.');
    }
//     ```

// ### Verificação de Valor de Propriedade:

// 1. **Comparação Direta:**
//    Você pode simplesmente comparar o valor da propriedade com um valor específico.

//     ```javascript
    const meuObjeto3 = { nome: 'Carlos', idade: 35 };

    if (meuObjeto3.nome === 'Carlos') {
        console.log('O valor da propriedade "nome" é Carlos.');
    }
//     ```

// 2. **Operador `===` (Verificação de Estrito Igual):**
//    Use o operador de igualdade estrita (`===`) para verificar se o valor é igual e do mesmo tipo.

//     ```javascript
    const meuObjeto4 = { nome: 'Ana', idade: 40 };

    if (meuObjeto4.idade === 40) {
        console.log('O valor da propriedade "idade" é 40.');
    }
//     ```

// 3. **Verificação de Existência e Valor em uma Condição:**
//    Combine a verificação de existência e valor em uma única condição.

//     ```javascript
    const meuObjeto5 = { nome: 'Pedro', idade: 45 };

    if ('idade' in meuObjeto5 && meuObjeto5.idade === 45) {
        console.log('A propriedade "idade" existe e tem o valor 45.');
    }
//     ```

// Escolha a abordagem que melhor se adapte às suas necessidades, dependendo se você precisa verificar apenas a existência, o valor ou ambos.