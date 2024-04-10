/*
As interfaces Typescript definem os contratos em sue código.
Eles também fornecem nomes exclicitos para verificação de tipo.
*/

interface IPessoa {
    nome: string;
    idade: number;
    readonly cpf: number;
    enabled(): boolean;
};

let pessoa: IPessoa = {
    nome: "Leandro",
    idade: 31,
    cpf: 11111111,
    enabled() {
        return true;
    },
};

class Joao implements IPessoa {
    nome: string = "Joao";
    idade: number = 33;
    readonly cpf: number = 1111111111
    enabled(): boolean {
        return true;
    }
}

