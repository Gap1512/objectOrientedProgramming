using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caEmpregadoGerente
{
    class Gerente : Empregado
    {
        private String secretaria;

        public Gerente() : base()
        {
            secretaria = "";
        }

        public Gerente(String _nome, String _secao, double _salario, String _secretaria)
            : base(_nome, _secao, _salario)
        {
            secretaria = _secretaria;
        }

        public String getSecretaria()
        {
            return secretaria;
        }

        public void setSecretaria(String _secretaria)
        {
            secretaria = _secretaria;
        }

        public override void aumentaSalario(double percentual)
        {
            base.aumentaSalario(percentual + 15.0);
        }
    }
}
