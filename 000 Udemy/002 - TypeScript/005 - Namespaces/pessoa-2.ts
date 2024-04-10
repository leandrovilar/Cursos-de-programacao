/*
Os Namespaces são suma forma específica de TypeScript para organizar código.
Namepaces são simplesmente objetos javaScript nomeados no namespace global.
Isso torna os namespaces uma construçao muito simples de usar.
*/

import { Pessoa1 } from "./pessoa-1";

console.log(Pessoa1.nome);
console.log(Pessoa1.calc());

import { Pessoa } from "./namespace-aninhados";

console.log (Pessoa.Pedro.nome)
console.log (Pessoa.Maria.nome)