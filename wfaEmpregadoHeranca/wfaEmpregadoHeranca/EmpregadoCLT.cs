using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaEmpregadoHeranca
{
    class EmpregadoCLT : Empregado
    {
        private double sBrutoCLT;
        
        public EmpregadoCLT() : base()
        {
            sBrutoCLT = .0;
        }

        public EmpregadoCLT(String _nome, String _cpf, String _endereco, double _sBrutoCLT)
            : base(_nome, _cpf, _endereco)
        {
            sBrutoCLT = _sBrutoCLT;
        }

        public double getsBrutoCLT()
        {
            return sBrutoCLT;
        }
        
        public void setsBrutoCLT(double _sBrutoCLT)
        {
            sBrutoCLT = _sBrutoCLT;
        }
        
        public override double salarioLiq()
        {
            return sBrutoCLT * 0.85;
        }
    }
}
