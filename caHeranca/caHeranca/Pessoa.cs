using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caHeranca
{
    class Pessoa
    {
        protected String nome;
        protected int idade;

        public Pessoa()
        {
            nome = "";
            idade = 0;
        }

        public Pessoa(String _nome, int _idade)
        {
            nome = _nome;
            idade = _idade;
        }

        public String getNome()
        {
            return nome;
        }

        public int getIdade()
        {
            return idade;
        }

        public void setNome(String _nome)
        {
            nome = _nome;
        }

        public void setIdade(int _idade)
        {
            idade = _idade;
        }
    }
}
