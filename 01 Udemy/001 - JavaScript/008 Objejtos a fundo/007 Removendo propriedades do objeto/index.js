//chatGPT
// Para remover propriedades de um objeto em JavaScript, você pode usar a palavra-chave `delete` ou criar um novo objeto excluindo a propriedade desejada. Vou mostrar ambas as abordagens:

// ### Usando a Palavra-Chave `delete`:

// A palavra-chave `delete` pode ser usada para remover uma propriedade específica de um objeto.

// ```javascript
// let pessoa = { nome: 'Alice', idade: 25, email: 'alice@email.com' };

// // Remover a propriedade 'email'
// delete pessoa.email;

// console.log(pessoa);
// ```

// **Observação:** O uso de `delete` pode ter implicações de desempenho em alguns casos, e nem sempre é a abordagem mais eficiente. Além disso, ele não afeta propriedades herdadas.

// ### Criando um Novo Objeto sem a Propriedade:

// Uma abordagem alternativa é criar um novo objeto excluindo a propriedade que você deseja remover.

// ```javascript
// let pessoa = { nome: 'Bob', idade: 30, telefone: '123-456-7890' };

// // Criar um novo objeto sem a propriedade 'telefone'
// let novaPessoa = { ...pessoa };
// delete novaPessoa.telefone;

// console.log(novaPessoa);
// ```

// ### Usando `Object.assign` para Excluir Propriedades:

// Outra abordagem para criar um novo objeto sem uma propriedade específica é usar `Object.assign`.

// ```javascript
// let pessoa = { nome: 'Charlie', idade: 35, endereco: 'Rua X' };

// // Criar um novo objeto sem a propriedade 'endereco'
// let { endereco, ...novaPessoa } = pessoa;

// console.log(novaPessoa);
// ```

// Nas abordagens que criam um novo objeto, a propriedade original não é alterada. Em ambas as formas, escolha a abordagem que melhor se adapta ao seu código e requisitos específicos.

// Aula
let Tenis = {
    tamonho: 45,
    estoque: true,
};

delete Tenis.estoque;
console.log(Tenis);

Tenis.estoque = true;
console.lot(Tenis);