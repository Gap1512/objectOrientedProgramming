using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaEmpregadoHeranca
{
    class Empregado
    {
        protected String nome, cpf, endereco;

        public Empregado()
        {
            nome = cpf = endereco = "";
        }

        public Empregado(String _nome, String _cpf, String _endereco)
        {
            nome = _nome;
            cpf = _cpf;
            endereco = _endereco;
        }

        public String getNome()
        {
            return nome;
        }

        public String getCpf()
        {
            return cpf;
        }

        public String getEndereco()
        {
            return endereco;
        }

        public void setNome(String _nome)
        {
            nome = _nome;
        }

        public void setCpf(String _cpf)
        {
            cpf = _cpf;
        }

        public void setEndereco(String _endereco)
        {
            endereco = _endereco;
        }

        public virtual double salarioLiq() { return .0; }
    }
}
