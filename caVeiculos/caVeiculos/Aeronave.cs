using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caVeiculos
{
    class Aeronave : Veiculo
    {
        private int qte_turbinas;

        public Aeronave (String _tipo, int _qte_turbinas) : base(_tipo)
        {
            qte_turbinas = _qte_turbinas;
        }

        public int getTurbinas()
        {
            return qte_turbinas;
        }

        public void setTurbinas(int _qte_turbinas)
        {
            qte_turbinas = _qte_turbinas;
        }

        public override void mover()
        {
            Console.WriteLine("Acelerando a aeronave");
        }

        public override void parar()
        {
            Console.WriteLine("Brecando a aeronave");
        }
    }
}
