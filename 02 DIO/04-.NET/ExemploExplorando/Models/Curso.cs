using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    //Class Curso
    public class Curso
    {
        //Propiedades
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        //Metodo
        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }
    }
}