/*
public - Pode seu acesado tanto pela mesma classe, 
        classe filhas e outras classes.
--------------------------------------------------------------------
Protected - pode ser acesssado pela mesma classe e classes filhas,
            nao pode ser acessado por outras classes.
--------------------------------------------------------------------
Private - Pode ser acessada somente pela própria classe.
*/

class Pessoa {
    public nome: string = "";
   public idade: number = 0;

   private _professor: string = "Programador"; // o andelien(_) atributo com privado

    /*Essa linha de código cria um atributo privado chamado _professor, que armazena
     o tipo string e é inicializado com o valor "Programador". Esse atributo só pode 
     ser acessado dentro da classe onde é definido.*/

    constructor(nome: string, idade: number) {
        this.nome = nome;
        this.idade = idade;
    }
    public comer(comida: string) {
        return `O ${this.nome} comeu ${comida}`
    }

    public fezAniversario(){
        return `O ${this.nome} fez tantos anos ${++this.idade}`;
    }
}

