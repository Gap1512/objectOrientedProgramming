using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caVeiculos
{
    class Veiculo
    {
        protected String tipo;

        public Veiculo(String _tipo)
        {
            tipo = _tipo;
        }

        public String getTipo()
        {
            return tipo;
        }

        public void setTipo(String _tipo)
        {
            tipo = _tipo;
        }

        public virtual void mover() { }
        public virtual void parar() { }
    }
}
