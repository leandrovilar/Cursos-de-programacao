/*
Getters e settes são usados para proteger seus dados, especialemte na criação de classes.

Para cada instância de variável, um método getter retorna seu valor, enquanto um método setter o define ou atualiza.
*/

class Pessoa {
    public nome: string = "";
    public idade: number = 0;

    constructor(nome: string, idade: number) {
        this.nome = nome;
        this.idade = idade;
    }
    public comer(comida: string) {
        return `O ${this.nome} comeu ${comida}`
    }

    public fezAniversario() {
        return `O ${this.nome} fez tantos anos ${++this.idade}`;
    }
}


class Leandro extends Pessoa {

    private _profissao: string = "Programador"

    constructor() {
        super("Leandro", 44)
    }

    get profissao(){
        if (this._profissao === "piloto"){
            return `Ele não é mais um Programador mudou para ${this._profissao}`;
        }
        return this._profissao;
    }

    set profissao(valor: string){
        this._profissao = valor;
    }

}
 const leandro = new Leandro();
 console.log(leandro.profissao);
 leandro.profissao = "piloto";
 console.log(leandro.profissao);
