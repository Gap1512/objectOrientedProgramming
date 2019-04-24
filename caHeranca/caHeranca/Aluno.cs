using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caHeranca
{
    class Aluno : Pessoa
    {
        private String curso;

        public Aluno() : base()
        {
            curso = "";
        }

        public Aluno(String _nome, int _idade, String _curso) : base(_nome, _idade)
        {
            curso = _curso;
        }

        public void imprimeDados()
        {
            Console.WriteLine("Dados do Aluno"  + "\n" +
                              "Nome: "  + nome  + "\n" +
                              "Idade: " + idade + "\n" +
                              "Curso: " + curso);
        }
    }
}
