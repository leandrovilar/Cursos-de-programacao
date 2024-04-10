/*
Os Namespaces são suma forma específica de TypeScript para organizar código.
Namepaces são simplesmente objetos javaScript nomeados no namespace global.
Isso torna os namespaces uma construçao muito simples de usar.
*/

// movido para teste no module.ts
// import { Pessoa1 } from "./pessoa-1";
// import { Pessoa } from "./namespace-aninhados";

import { Pessoa1, Pessoa } from "./module";

console.log(Pessoa1.nome);
console.log(Pessoa1.calc());

console.log (Pessoa.Pedro.nome)
console.log (Pessoa.Maria.nome)