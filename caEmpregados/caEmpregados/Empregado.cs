using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caEmpregados
{
    class Empregado
    {
        protected String primeiroNome, segundoNome, CPF;

        public Empregado()
        {
            primeiroNome = "";
            segundoNome = "";
            CPF = "";
        }

        public Empregado(String _primeiroNome, String _segundoNome, String _CPF)
        {
            primeiroNome = _primeiroNome;
            segundoNome = _segundoNome;
            CPF = _CPF;
        }

        public String getPrimeiroNome()
        {
            return primeiroNome;
        }

        public String getSegundoNome()
        {
            return segundoNome;
        }

        public String getCPF()
        {
            return CPF;
        }

        public void setPrimeiroNome(String _primeiroNome)
        {
            primeiroNome = _primeiroNome;
        }

        public void setSegundoNome(String _segundoNome)
        {
            segundoNome = _segundoNome;
        }

        public void setCPF(String _CPF)
        {
            CPF = _CPF;
        }

        public virtual double getSalLiquido() { return .0; }

    }
}
