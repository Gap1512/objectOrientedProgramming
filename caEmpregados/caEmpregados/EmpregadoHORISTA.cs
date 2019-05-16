using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caEmpregados
{
    class EmpregadoHORISTA : Empregado
    {
        private double nroHoras, qteHoras;

        public EmpregadoHORISTA() : base()
        {
            nroHoras = qteHoras = .0;
        }

        public EmpregadoHORISTA(String _primeiroNome, String _segundoNome, String _CPF, double _nroHoras, double _qteHoras)
            : base(_primeiroNome, _segundoNome, _CPF)
        {
            nroHoras = _nroHoras;
            qteHoras = _qteHoras;
        }

        public double getNroHoras()
        {
            return nroHoras;
        }

        public double getQteHoras()
        {
            return qteHoras;
        }

        public void setNroHoras(double _nroHoras)
        {
            nroHoras = _nroHoras;
        }

        public void setQteHoras(double _qteHoras)
        {
            qteHoras = _qteHoras;
        }

        public override double getSalLiquido()
        {
            return (nroHoras * qteHoras) * 0.85;
        }
    }
}
