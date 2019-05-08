using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaEmpregadoHeranca
{
    class EmpregadoHorista : Empregado
    {
        private int nHoras;
        private double precoH;

        public EmpregadoHorista() : base()
        {
            nHoras = 0;
            precoH = .0;
        }

        public EmpregadoHorista(String _nome, String _cpf, String _endereco, int _nHoras, double _precoH)
            : base(_nome, _cpf, _endereco)
        {
            nHoras = _nHoras;
            precoH = _precoH;
        }

        public int getnHoras()
        {
            return nHoras;
        }

        public double getpHoras()
        {
            return precoH;
        }

        public void setnHoras(int _nHoras)
        {
            nHoras = _nHoras;
        }

        public void setpHoras(double _precoH)
        {
            precoH = _precoH;
        }

        public override double salarioLiq()
        {
            double sBruto = nHoras * precoH;
            return (sBruto > 5000.0) ? (sBruto * 0.725) : (sBruto * 0.85);
        }

    }
}
