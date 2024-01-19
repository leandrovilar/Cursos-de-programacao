//ChatGPT
/*Uma closure (fechamento) em JavaScript é a combinação de uma função e o ambiente léxico (escopo) no qual essa função foi declarada. Isso permite que a função acesse variáveis externas, mesmo após a execução da função ter sido concluída. Em termos simples, uma closure lembra do escopo no qual foi criada e tem acesso a essas variáveis mesmo que seja chamada fora desse escopo.
*/

//Vamos ver um exemplo:
function exterior() {
    let mensagem = "Olá, ";

    function interior(nome) {
        console.log(mensagem + nome);
    }

    return interior;
}

let saudacao = exterior();
saudacao("João"); // Saída: Olá, João

/*
No exemplo acima:

1. A função `exterior` declara uma variável `mensagem` e define uma função `interior` que tem acesso à variável `mensagem`.
2. A função `exterior` retorna a função `interior`.
3. A função retornada é armazenada na variável `saudacao`.
4. Quando chamamos `saudacao("João")`, a função `interior` é executada, e como ela foi criada dentro do escopo de `exterior`, ela ainda tem acesso à variável `mensagem`.

A closure permite que a função interna (`interior`) acesse variáveis da função externa (`exterior`), mesmo que a função externa já tenha concluído sua execução.

Closures são úteis em situações como:

- **Encapsulamento de Variáveis:** Permite criar espaços privados para variáveis, evitando poluição do escopo global.
- **Callback Functions:** São comuns ao usar funções de retorno de chamada, especialmente em eventos assíncronos.
- **Módulos:** Facilitam a implementação de padrões de projeto de módulos em JavaScript.

É importante entender closures para escrever código mais eficiente e compreender alguns padrões de design comuns em JavaScript.
*/


//Udemy
/* 
Uma closure ocorre normalmente quando uma funçao é declarada dentro do corpo de 
outra, e a funçao interior referecia variáveis locais da funçao exterior.
*/

//Exemplo 1
function QualSeuNome(name) {
    const msg = `O seu nome é:`;

    function SeuName() {
        return `${msg} ${name}`;
    }
    return SeuName();
}
console.log(QualSeuNome("Dener"));

// Exemplo 2
function Calculadora(num1, num2) {
    const msg = "Resultado:";

    const soma = () => {
        return `${msg} ${num1 + num2}`;
    };

    const subtracao = () => {
        return `${msg} ${num1 - num2}`;
    };

    const multiplicacao = () => {
        return `${msg} ${num1 * num2}`;
    };

    const divisao = () => {
        return `${msg} ${num1 / num2}`;
    };

    return {
        soma: soma(),
        subtracao: subtracao(),
        multiplicacao: multiplicacao(),
        divisao: divisao(),
    };
}
console.log(Calculadora(10, 5));

