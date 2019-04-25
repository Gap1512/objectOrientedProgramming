using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caEmpregadoGerente
{
    class Empregado
    {
        protected String nome;
        protected String secao;
        protected double salario;

        public Empregado()
        {
            nome = "";
            secao = "";
            salario = .0;
        }

        public Empregado(String _nome, String _secao, double _salario)
        {
            nome = _nome;
            secao = _secao;
            salario = _salario;
        }

        public String getNome()
        {
            return nome;
        }

        public String getSecao()
        {
            return secao;
        }

        public double getSalario()
        {
            return salario;
        }

        public void setNome(String _nome)
        {
            nome = _nome;
        }

        public void setSecao(String _secao)
        {
            secao = _secao;
        }

        public void setSalario(double _salario)
        {
            salario = _salario;
        }

        public virtual void aumentaSalario(double percentual)
        {
            salario *= 1 + percentual / 100;
        }
    }
}
