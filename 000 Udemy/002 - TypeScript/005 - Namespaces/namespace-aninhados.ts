/*
Os Namespaces são suma forma específica de TypeScript para organizar código.
Namepaces são simplesmente objetos javaScript nomeados no namespace global.
Isso torna os namespaces uma construçao muito simples de usar.
*/

export namespace Pessoa {
    export namespace Maria {
        const data = 1 + 1;

        export let nome = "Maria";
        export const calc = () => {
            return data;
        };
    }
    export namespace Pedro {
        const data = 1 + 1;

        export let nome = "Pedro";
        export const calc = () => {
            return data;
        };
    }
}
