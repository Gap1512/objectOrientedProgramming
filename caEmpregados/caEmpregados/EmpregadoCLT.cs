using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caEmpregados
{
    class EmpregadoCLT : Empregado
    {
        private double salarioMensal;

        public EmpregadoCLT() : base()
        {
            salarioMensal = .0;
        }

        public EmpregadoCLT(String _primeiroNome, String _segundoNome, String _CPF, double _salarioMensal)
            : base(_primeiroNome, _segundoNome, _CPF)
        {
            salarioMensal = _salarioMensal;
        }

        public double getSalarioMensal()
        {
            return salarioMensal;
        }

        public void setSalarioMensal(double _salarioMensal)
        {
            salarioMensal = _salarioMensal;
        }

        public override double getSalLiquido()
        {
            return (salarioMensal < 4000.0) ? (salarioMensal * 0.85) : (salarioMensal * 0.725);
        }
    }
}
